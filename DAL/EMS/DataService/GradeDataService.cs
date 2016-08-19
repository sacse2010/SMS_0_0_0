using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManager;
using Entities.EMS;

namespace DAL.EMS.DataService
{
    public class GradeDataService
    {
        CommonConnection connection = new CommonConnection();

        public string GradeDataSave(GradeEntity objGrade)
        {
            string rv = "";
            string query;
            //CommonConnecti
            try
            {
                string condition;
                if (objGrade.GradeId == 0)
                {
                    condition = string.Format(@"Where GradeName='{0}'", objGrade.GradeName);
                }
                else
                {
                    condition = string.Format(@" Where GradeName='{0}' And GradeId !={1}", objGrade.GradeName, objGrade.GradeId);
                }

                var res = GetExistGradeName(condition);
                if (res > 0)
                {
                    return Operation.Exists.ToString();
                }

                if (objGrade.GradeId == 0)
                {
                    query = string.Format(@"Insert Into Grade (GradeName, GradePoint, MarkForm, MarkUpto, Description, IsActive) 
                Values('{0}',{1},{2},{3},'{4}',{5})", objGrade.GradeName, objGrade.GradePoint, objGrade.MarkForm, objGrade.MarkUpto,
                                                        objGrade.Description, objGrade.IsActive);
                }
                else
                {
                    query = string.Format(@"Update Grade Set GradeName='{0}', GradePoint={1}, MarkForm={2}, MarkUpto={3}, Description='{4}', IsActive={5} 
                                            Where GradeId={6}", objGrade.GradeName, objGrade.GradePoint, objGrade.MarkForm, objGrade.MarkUpto,
                                            objGrade.Description, objGrade.IsActive, objGrade.GradeId);
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

        public int GetExistGradeName(string condition)
        {
            try
            {
                string sql = string.Format(@"Select * From Grade {0}", condition);
                var data = Data<GradeEntity>.DataSource(sql);
                return data.Count;

            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public GridEntity<GradeEntity> GetGridData(GridOptions options)
        {
            string sql = "Select * from Grade";
            var data = Kendo<GradeEntity>.Grid.DataSource(options, sql, "GradeId DESC");
            return data;
        }
    }
}
