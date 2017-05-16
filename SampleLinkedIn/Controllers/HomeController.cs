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
            string filename = Server.MapPath("~/PPTs/") + "VisualStudio2017.pptx";
            string contentType = "application/vnd.ms-powerpoint";
            return File(filename, contentType, "sample.pptx");
        }
    }
}