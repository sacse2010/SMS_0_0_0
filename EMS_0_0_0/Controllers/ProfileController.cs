using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMS_0_0_0.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
      
        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult UploadImage()
        {
            foreach (string item in Request.Files)
            {
                HttpPostedFileBase file = Request.Files[item] as HttpPostedFileBase;
                string fileName = file.FileName;
                string UploadPath = "~/Upload/";

                if (file.ContentLength == 0)
                    continue;
                if (file.ContentLength > 0)
                {
                    string path = Path.Combine(HttpContext.Request.MapPath(UploadPath), fileName);
                    string extension = Path.GetExtension(file.FileName);

                    file.SaveAs(path);
                }
            }

            return Json("Uploaded Successfully");

        }
    }
}