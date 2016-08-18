using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManager;
using Entities.EMS;

namespace DAL.EMS.DataService
{
   public class SemesterDataService
    {
        CommonConnection connection =new CommonConnection();

       public string SemesterDataSave(SemesterEntiry objSemester)
       {
            string rv = "";
            string query;
            //CommonConnecti
            try
            {
                string condition;
                if (objSemester.SemesterId == 0)
                {
                    condition = string.Format(@"Where Name='{0}'", objSemester.Name);
                }
                else
                {
                    condition = string.Format(@" Where Name='{0}' And SemesterId !={1}", objSemester.Name, objSemester.SemesterId);
                }

                var res = GetExistSemesterName(condition);
                if (res > 0)
                {
                    return Operation.Exists.ToString();
                }

                if (objSemester.SemesterId == 0)
                {
                    query = string.Format(@"Insert Into SemesterInfo (Name, Description, IsActive) 
                Values('{0}','{1}', {2})", objSemester.Name, objSemester.Description, objSemester.IsActive);
                }
                else
                {
                    query = string.Format(@"Update SemesterInfo Set Name='{0}', Description='{1}', IsActive={2} 
                                            Where SemesterId={3}", objSemester.Name, objSemester.Description, objSemester.IsActive, objSemester.SemesterId);
                }
                connection.ExecuteNonQuery(query);
                rv = Operation.Success.ToString();
            }
            catch (Exception exception)
            {
                rv = exception.Message;
            }
            return rv;
        }

       private int GetExistSemesterName(string condition)
       {
            try
            {
                string sql = string.Format(@"Select * From SemesterInfo {0}", condition);
                var data = Data<SubjectEntity>.DataSource(sql);
                return data.Count;

            }
            catch (Exception ex)
            {
                return 0;
            }
        }

       public GridEntity<SemesterEntiry> GetGridData(GridOptions options)
       {
           string sql = "Select * from SemesterInfo";
           var data = Kendo<SemesterEntiry>.Grid.DataSource(options, sql, "SemesterId DESC");
           return data;
       }
    }
}
