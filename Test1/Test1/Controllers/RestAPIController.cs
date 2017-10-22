using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class RestAPIController : Controller
    {
        // GET: RestAPI
        public ActionResult Index()
        {
            return View();
        }

        public Profile getProfile()
        {
            Profile profile = new Profile();
            profile.Name = "Wang Dan";
            profile.Rating = 4.9f;
            profile.Review = 120;
            profile.LocalKnowledge = 4.8f;
            profile.ProcessExpertise = 4.2f;
            profile.Responsiveness = 5.0f;
            profile.NegotitationSkills = 4.1f;

            profile.About = "Please contact me. ASP MVC professional is here.";

            return profile;
        }

        public List<RealEstate> getEstates()
        {
            RealEstate estate1 = new RealEstate();
            estate1.Price = 123;
            estate1.Price = 23;
            estate1.Address = "ShenYang";
            estate1.Bath = 2;
            estate1.Beds = 30;
            estate1.Soft = 2894;

            RealEstate estate2 = new RealEstate();
            estate2.Price = 1223;
            estate2.Price = 232;
            estate2.Address = "Argentina";
            estate2.Bath = 21;
            estate2.Beds = 301;
            estate2.Soft = 28914;

            List<RealEstate> arList = new List<RealEstate>();
            arList.Add(estate1);
            arList.Add(estate2);

            return arList;
        }



        public List<Sale> getSales()
        {

            RealEstate estate1 = new RealEstate();
            estate1.Price = 123;
            estate1.Price = 23;
            estate1.Address = "ShenYang";
            estate1.Bath = 2;
            estate1.Beds = 30;
            estate1.Soft = 2894;

            RealEstate estate2 = new RealEstate();
            estate2.Price = 1223;
            estate2.Price = 232;
            estate2.Address = "Argentina";
            estate2.Bath = 21;
            estate2.Beds = 301;
            estate2.Soft = 28914;

            List<Sale> arSales = new List<Sale>();

            Sale sale1 = new Sale();
            sale1.Estate = estate1;
            sale1.Date = "09/12/2017";

            Sale sale2 = new Sale();
            sale2.Estate = estate2;
            sale2.Date = "10/12/2017";

            arSales.Add(sale1);
            arSales.Add(sale2);

            return arSales;
        }

        public List<Review> getReviews()
        {
            Review review1 = new Review();
            review1.Date = "09/24/2017";
            review1.Rating = 4.5f;

            review1.Responsiveness = 4.5f;
            review1.LocalKnowledge = 4.5f;
            review1.ProcessExpertise = 4.5f;
            review1.NegotitationSkills = 4.5f;

            review1.Name = "Wang Dan";
            review1.Note = "Please contact me";

            Review review2 = new Review();
            review2.Date = "10/24/2017";
            review2.Rating = 4.8f;

            review2.Responsiveness = 4.8f;
            review2.LocalKnowledge = 4.2f;
            review2.ProcessExpertise = 3.5f;
            review2.NegotitationSkills = 1.5f;

            review2.Name = "You Dan";
            review2.Note = "Please contact you";

            List<Review> arReviews = new List<Review>();
            arReviews.Add(review1);
            arReviews.Add(review2);

            return arReviews;
        }
    }
}