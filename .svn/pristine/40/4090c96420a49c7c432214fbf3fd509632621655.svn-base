using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EMS.DataService;
using DBManager;
using Entities.EMS;

namespace BLL.EMS.Test
{
    public class TestService:ITestRepository
    {
        TestDataService _testDataService = new TestDataService();

        public string SaveTestData(TestEntity objTest)
        {
            return _testDataService.SaveTestData(objTest);
        }

        public GridEntity<TestEntity> GetTestSummary(GridOptions options)
        {
            return _testDataService.GetGridData(options);
        }

        public List<TestEntity> GetTestTypeComboData()
        {
            return _testDataService.GetTestTypeComboData();
        }
    }
}
