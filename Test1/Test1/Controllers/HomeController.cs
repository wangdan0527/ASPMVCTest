using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewModel model = new ViewModel();
            
            model.profile = new RestAPIController().getProfile(); ;
            model.arEstates = new RestAPIController().getEstates();
            model.arSales = new RestAPIController().getSales();
            model.arReviews = new RestAPIController().getReviews();

            return View(model);
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