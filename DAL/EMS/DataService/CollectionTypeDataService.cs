using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBManager;
using Entities.EMS;

namespace DAL.EMS.DataService
{
   public class CollectionTypeDataService
    {
        CommonConnection connection =new CommonConnection();
       public string CollectionTypeDataSave(CollectionTypeEntity objCollectionType)
       {
            string rv = "";
            string query;
            //CommonConnecti
            try
            {
                string condition;
                if (objCollectionType.CollectionId == 0)
                {
                    condition = string.Format(@"Where CollectionType='{0}'", objCollectionType.CollectionType);
                }
                else
                {
                    condition = string.Format(@" Where CollectionType='{0}' And CollectionId !={1}", objCollectionType.CollectionType, objCollectionType.CollectionId);
                }

                var res = GetExistCollectionType(condition);
                if (res > 0)
                {
                    return Operation.Exists.ToString();
                }

                if (objCollectionType.CollectionId == 0)
                {
                    query = string.Format(@"Insert Into CollectionType (CollectionType, Description, IsActive) 
                Values('{0}','{1}', {2})", objCollectionType.CollectionType, objCollectionType.Description, objCollectionType.IsActive);
                }
                else
                {
                    query = string.Format(@"Update CollectionType Set CollectionType='{0}', Description='{1}', IsActive={2} 
                                            Where CollectionId={3}", objCollectionType.CollectionType, objCollectionType.Description, objCollectionType.IsActive, objCollectionType.CollectionId);
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

       private int GetExistCollectionType(string condition)
       {
            try
            {
                string sql = string.Format(@"Select * From CollectionType {0}", condition);
                var data = Data<ClassEntity>.DataSource(sql);
                return data.Count;

            }
            catch (Exception ex)
            {
                return 0;
            }
        }

       public GridEntity<CollectionTypeEntity> GetGridData(GridOptions options)
       {
            string sql = "Select * From CollectionType";
            var data = Kendo<CollectionTypeEntity>.Grid.DataSource(options, sql, "CollectionId DESC");
            return data;
        }
    }
}
