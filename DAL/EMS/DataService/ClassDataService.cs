using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManager;
using Entities.EMS;

namespace DAL.EMS.DataService
{
   public class ClassDataService
    {
        CommonConnection connection =new CommonConnection();

       public string ClassDataSave(ClassEntity objClass)
       {
            string rv = "";
            string query;
            //CommonConnecti
            try
            {
                string condition;
                if (objClass.ClassId == 0)
                {
                    condition = string.Format(@"Where Name='{0}'", objClass.Name);
                }
                else
                {
                    condition = string.Format(@" Where Name='{0}' And ClassId !={1}", objClass.Name, objClass.ClassId);
                }

                var res = GetExistClassName(condition);
                if (res > 0)
                {
                    return Operation.Exists.ToString();
                }

                if (objClass.ClassId == 0)
                {
                    query = string.Format(@"Insert Into ClassInfo (Name, Description, IsActive) 
                Values('{0}','{1}', {2})", objClass.Name, objClass.Description, objClass.IsActive);
                }
                else
                {
                    query = string.Format(@"Update ClassInfo Set Name='{0}', Description='{1}', IsActive={2} 
                                            Where ClassId={3}", objClass.Name, objClass.Description, objClass.IsActive, objClass.ClassId);
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

       private int GetExistClassName(string condition)
       {
            try
            {
                string sql = string.Format(@"Select * From ClassInfo {0}", condition);
                var data = Data<ClassEntity>.DataSource(sql);
                return data.Count;

            }
            catch (Exception ex)
            {
                return 0;
            }
        }

       public GridEntity<ClassEntity> GetGridData(GridOptions options)
       {
            string sql = "Select * From ClassInfo";
            var data = Kendo<ClassEntity>.Grid.DataSource(options, sql, "ClassId DESC");
            return data;
        }
    }
}
