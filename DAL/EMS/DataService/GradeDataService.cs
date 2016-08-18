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
        CommonConnection connection =new CommonConnection();

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
                    condition = string.Format(@"Where Name='{0}'", objGrade.Name);
                }
                else
                {
                    condition = string.Format(@" Where Name='{0}' And GradeId !={1}", objGrade.Name, objGrade.GradeId);
                }

                var res = GetExistGradeName(condition);
                if (res > 0)
                {
                    return Operation.Exists.ToString();
                }

                if (objGrade.GradeId == 0)
                {
                    query = string.Format(@"Insert Into Grade (Name, IsActive) 
                Values('{0}',{1})", objGrade.Name,  objGrade.IsActive);
                }
                else
                {
                    query = string.Format(@"Update Grade Set Name='{0}', IsActive={1} 
                                            Where GradeId={2}", objGrade.Name, objGrade.IsActive, objGrade.GradeId);
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
