using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.EMS.CollectionType;
using DBManager;
using Entities.EMS;

namespace EMS_0_0_0.Controllers
{
    public class CollectionTypeController : Controller
    {
        ICollectionTypeRepository _collectionTypeRepository =new CollectiontypeService();
        // GET: CollectionType
        public ActionResult CollectionType()
        {
            return View();
        }

        public ActionResult CollectionTypeDataSave(CollectionTypeEntity objCollectionType)
        {
            var res = Json(_collectionTypeRepository.CollectionTypeDataSave(objCollectionType), JsonRequestBehavior.AllowGet);
            return res;
        }
        public JsonResult GetCollectionTypeSummary(GridOptions options)
        {
            var res = Json(_collectionTypeRepository.GetCollectionTypeSummary(options), JsonRequestBehavior.AllowGet);
            return res;
        }

    }
}