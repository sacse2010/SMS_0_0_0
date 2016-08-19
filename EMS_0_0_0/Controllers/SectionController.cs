using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.EMS.Section;
using DBManager;
using Entities.EMS;

namespace EMS_0_0_0.Controllers
{
    public class SectionController : Controller
    {
        ISectionReposiroty _sectionReposiroty = new SectionService();
        // GET: Section
        public ActionResult Section()
        {
            return View();
        }

        public ActionResult SectionDataSave(SectionEntity objSection)
        {
            var res = Json(_sectionReposiroty.SectionDataSave(objSection), JsonRequestBehavior.AllowGet);
            return res;
        }

        public JsonResult GetSectionSummary(GridOptions option)
        {
            var res = Json(_sectionReposiroty.GetSectionSummary(option), JsonRequestBehavior.AllowGet);
            return res;
        }
    }
}