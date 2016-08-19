using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.EMS.Class;
using DBManager;
using Entities.EMS;

namespace EMS_0_0_0.Controllers
{
    public class ClassInfoController : Controller
    {
        IClassRepositorycs _classRepositorycs =new ClassService();
        // GET: ClassInfo
        public ActionResult ClassInfo()
        {
            return View();
        }

        public ActionResult ClassDataSave(ClassEntity objClass)
        {
            var res = Json(_classRepositorycs.ClassDataSave(objClass), JsonRequestBehavior.AllowGet);
            return res;
        }
        public JsonResult GetClassSummary(GridOptions option)
        {
            var res = Json(_classRepositorycs.GetClassSummary(option), JsonRequestBehavior.AllowGet);
            return res;
        }
    }
}