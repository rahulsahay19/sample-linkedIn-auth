using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleLinkedIn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       // [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public FileResult LoadContentResult(int Id)
        {
            string fileName;
            string contentType;
            var completeString = IdentifyFileToDownload(Id, out fileName, out contentType);
            return File(completeString, contentType,fileName);
        }

        private string IdentifyFileToDownload(int Id, out string fileName, out string contentType)
        {
            string completeString;
            var mapPath = Server.MapPath("~/PPTs/");
          //  string fileName;
            if (Id == 1)
            {
                fileName = "VisualStudio2017.pptx";
                completeString = mapPath + fileName;
            }
            else if (Id == 2)
            {
                fileName = "ASPNET.pptx";
                completeString = mapPath + fileName;
            }
            else
            {
                fileName = "B812.pptx";
                completeString = mapPath + fileName;
            }
            //string filename = Server.MapPath("~/PPTs/") + "VisualStudio2017.pptx";
            contentType = "application/vnd.ms-powerpoint";
            return completeString;
        }
    }
}