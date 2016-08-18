using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.EMS.Grade;
using DBManager;
using Entities.EMS;

namespace EMS_0_0_0.Controllers
{
    public class GradeController : Controller
    {
        IGradeRepository _gradeRepository =new GradeService();
        // GET: Grade
        public ActionResult Grade()
        {
            return View();
        }

        public ActionResult GradeDataSave(GradeEntity objGrade)
        {
            var res = Json(_gradeRepository.GradeDataSave(objGrade));
            return res;
        }

        public JsonResult GetGradeSummary(GridOptions options)
        {
            var res = Json(_gradeRepository.GetGradeSummary(options), JsonRequestBehavior.AllowGet);
            return res;
        }

    }
}