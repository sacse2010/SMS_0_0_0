using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DBManager;
using Entities.EMS;

namespace DAL.EMS.DataService
{
   
   public class TestDataService
    {
       CommonConnection connection = new CommonConnection();

       //For Save Data
       public string SaveTestData(TestEntity objTest)
       {
           string rv = "";

           try
           {
               string sql = String.Format(@"Insert Into Test (TestCode,TestName,TestDescription) 
            Values('{0}','{1}','{2}')", objTest.TestCode, objTest.TestName, objTest.TestDescription);
               connection.ExecuteNonQuery(sql);
               rv = Operation.Success.ToString();
           }
           catch (Exception exception)
           {
               rv = exception.Message;
           }

           return rv;
       }

       //For Get Data For Combo
       public List<TestEntity> GetData()
       {
           string sql = "";
           var data = Kendo<TestEntity>.Combo.DataSource(sql);
           return data;
       }

       //For Get Data For Grid
       public GridEntity<TestEntity> GetGridData(GridOptions options)
       {
           string sql = "Select * From Test";
           var data = Kendo<TestEntity>.Grid.DataSource(options,sql,"TestCode");
           return data;
       }


       public List<TestEntity> GetTestTypeComboData()
       {
           string sql = "Select * From Test";
           var data = Kendo<TestEntity>.Combo.DataSource(sql);
           return data;
       }
    }
}
