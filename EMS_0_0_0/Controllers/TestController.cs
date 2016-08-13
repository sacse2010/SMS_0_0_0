using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.EMS.Test;
using DBManager;
using Entities.EMS;

namespace EMS_0_0_0.Controllers
{
    public class TestController : Controller
    {
        ITestRepository _testRepository = new TestService();
        // GET: Test
        public ActionResult Test()
        {
            return View();
        }

          [HttpPost]
        public ActionResult SaveTestData(TestEntity objTest)
        {
            var res = Json(_testRepository.SaveTestData(objTest),JsonRequestBehavior.AllowGet);
            return res;
        }

        public JsonResult GetTestSummary(GridOptions options)
        {
            ITestRepository _testRepository = new TestService();
            var res = Json(_testRepository.GetTestSummary(options), JsonRequestBehavior.AllowGet);
            return res;
            
        }

        public JsonResult GetTestTypeComboData()
        {
            ITestRepository _testRepository = new TestService();

            var res = Json(_testRepository.GetTestTypeComboData(), JsonRequestBehavior.AllowGet);
            return res;
        }
    }
}