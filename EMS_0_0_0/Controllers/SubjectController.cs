using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.EMS.Subject;
using DBManager;
using Entities.EMS;

namespace EMS_0_0_0.Controllers
{
    public class SubjectController : Controller
    {
        ISubjectRepository _subjectRepository =new SubjectService();
        // GET: Subject
        public ActionResult Subject()
        {
            return View();
        }

        public ActionResult SaveSubjectData(SubjectEntity objSubject)
        {
            var res = Json(_subjectRepository.SaveSubjectData(objSubject), JsonRequestBehavior.AllowGet);
            return res;
        }
        public JsonResult GetSubjectSummary(GridOptions options)
        {
          
            var res = Json(_subjectRepository.GetSubjectSummary(options), JsonRequestBehavior.AllowGet);
            return res;

        }


    }
}