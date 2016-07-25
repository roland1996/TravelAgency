using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using TravelAgency.BL;
using TravelAgency.BL.DTO;
using TravelAgency.BL.Infrastructure;

namespace TravelAgency.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult result()
        {
            CountryPointsParser parser = new CountryPointsParser();

            var jsonSerialiser = new JavaScriptSerializer();
            var json = jsonSerialiser.Serialize(parser.load(@"C:\Users\Женя\documents\visual studio 2015\Projects\TravelAgency\TravelAgency\Files\result.txt"));
            return Json(json);
        }
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

    }
}