using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MovieController : Controller
    {
        public static List<Movie> ll = new List<Movie>
        {
            new Movie(1,"Om Shanti Om","Its based on a true event","Action",2.30,new DateTime(2020,8,28),new TimeSpan(14,30,0),50),
            new Movie(2,"Kalki","Its based on future technologies","Thriller",3,new DateTime(2024,7,26),new TimeSpan(10,30,0),70),
            new Movie(3,"Avenger End Game","Its a super hero movie","Action",3.30,new DateTime(2019,6,1),new TimeSpan(20,30,0),80)
        };



        // GET: Movie
        public ActionResult Index()
        {
    
            return View(ll);
        }

        public ActionResult Add()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Add(Movie mv)
        {

            ll.Add(mv);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
       
            ViewBag.customList = Session["showtime"] as List<ShowTime>;

            ViewBag.ID = id;

            return View(ll);
        }
    }
}