using System;
using U21557277_HW03.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;

namespace U21557277_HW03.Controllers
{
    public class ImagesController : Controller
    {
        // GET: Images
        public ActionResult Index()
        {
           

            string[] filePaths = System.IO.Directory.GetFiles(Server.MapPath("~/App_Data/Media/Images/"));

            
            List<FileModel> files = new List<FileModel>();

            foreach (string filePath in filePaths)
            {
                files.Add(new FileModel { FileName = Path.GetFileName(filePath) });
            }
            return View(files);
        }

        public FileResult DownloadFile(string fileName) 
        {
            

            string path = Server.MapPath("~/App_Data/Media/Images/") + fileName;

           

            byte[] bytes = System.IO.File.ReadAllBytes(path);

            

            return File(bytes, "application/octet-stream", fileName);
        }

        public ActionResult DeleteFile(string fileName)
        {
            
            string path = Server.MapPath("~/App_Data/Media/Images/") + fileName;
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            System.IO.File.Delete(path);

            return RedirectToAction("Index");
        }

    }
}
