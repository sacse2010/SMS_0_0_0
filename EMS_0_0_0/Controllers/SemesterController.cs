using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.EMS.Semester;
using DBManager;
using Entities.EMS;

namespace EMS_0_0_0.Controllers
{
    public class SemesterController : Controller
    {
        ISemesterRepository _semesterRepository =new SemesterService();
        // GET: Semester
        public ActionResult Semester()
        {
            return View();
        }

        public ActionResult SemesterDataSave(SemesterEntiry objSemester)
        {
            var res = Json(_semesterRepository.SemesterDataSave(objSemester), JsonRequestBehavior.AllowGet);
            return res;
        }

        public JsonResult GetSemesterSummary(GridOptions options)
        {
            var res = Json(_semesterRepository.GetSemesterSummary(options), JsonRequestBehavior.AllowGet);
            return res;
        }


    }
}