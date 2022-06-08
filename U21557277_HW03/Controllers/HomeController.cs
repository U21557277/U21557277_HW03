using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace U21557277_HW03.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase[] Files)
        {
           
            if (ModelState.IsValid)
            {  
                foreach (HttpPostedFileBase file in Files)
                {
                    
                    if (file != null)
                    {
                        var InputFileName = Path.GetFileName(file.FileName);
                        var ServerSavePath = Path.Combine(Server.MapPath("~/App_Data/Media/Documents/") + InputFileName);
                        
                        file.SaveAs(ServerSavePath);
                    }
                }
            }
            return View();
        }
    }
}