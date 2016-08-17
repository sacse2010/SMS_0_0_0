using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManager;
using Entities.EMS;

namespace DAL.EMS.DataService
{
    public class SubjectDataService
    {
        private CommonConnection connection = new CommonConnection();
        //For Save Data
        public string SaveSubjectData(SubjectEntity objSubject)
        {
            string rv = "";
            string query;
            //CommonConnection con = new CommonConnection(IsolationLevel.ReadCommitted);
            //con.BeginTransaction();
            try
            {
                string condition;
                if (objSubject.SubjectId == 0)
                {
                    condition = " Where SubjectCode=" + objSubject.SubjectCode;
                }
                else
                {
                    condition = string.Format(@" Where SubjectCode='{0}' And SubjectId !={1}", objSubject.SubjectCode,
                        objSubject.SubjectId);
                }

                var res = GetExistSubjectCode(condition);
                if (res > 0)
                {
                    return Operation.Exists.ToString();
                }

                if (objSubject.SubjectId == 0)
                {
                    query = string.Format(@"Insert Into SubjectInfo (SubjectCode,Name,Description,IsActive) 
                Values('{0}','{1}','{2}',{3})", objSubject.SubjectCode, objSubject.Name, objSubject.Description,
                        objSubject.IsActive);
                }
                else
                {
                    query =
                        string.Format(@"Update SubjectInfo Set SubjectCode='{0}', Name='{1}', Description='{2}', IsActive='{3}' 
                                            Where SubjectId={4}", objSubject.SubjectCode, objSubject.Name, objSubject.Description,
                            objSubject.IsActive, objSubject.SubjectId);
                }
              //  var id = con.ExcuteSqlAfterReturn(sql);
                connection.ExecuteNonQuery(query);
                rv = Operation.Success.ToString();
               // con.CommitTransaction();
            }
            catch (Exception exception)
            {
                 rv = exception.Message;
                //con.RollBack();
            }

            return rv;
        }
        public int GetExistSubjectCode(string condition)
        {
            try
            {
                string sql = string.Format(@" Select * From SubjectInfo {0}", condition);
                var data =  Data<SubjectEntity>.DataSource(sql);
                return data.Count;

            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        public GridEntity<SubjectEntity>GetGridData(GridOptions options)
        {
            string sql = "Select * From SubjectInfo";
            var data = Kendo<SubjectEntity>.Grid.DataSource(options, sql, "SubjectCode DESC");
            return data;
        }
    }
}
