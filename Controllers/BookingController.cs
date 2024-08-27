using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class BookingController : Controller
    {
     
        // GET: Booking
        public ActionResult Book(int id)
        {
            Booking b= new Booking();
            b.Id = id;
            b.ShowtimeId = id;
            System.Diagnostics.Debug.WriteLine("This will be displayed in output window "+b.Id);

            return View(b);
        }

        [HttpPost]
        public ActionResult Book(Booking b)
        {
            
            for(int i = 0; i < MovieController.ll.Count; i++)
            {
               
                if (MovieController.ll[i].Id == b.ShowtimeId && MovieController.ll[i].Show.AvailableSeats - b.NumberOfSeats>=0)
                {
                    MovieController.ll[i].Show.AvailableSeats = MovieController.ll[i].Show.AvailableSeats - b.NumberOfSeats;
                    TimeSpan t = MovieController.ll[i].Show.Showtime;

                    return RedirectToAction("Confirmation",new {email=b.Email,seats=b.NumberOfSeats,t});
                }
            }
            System.Diagnostics.Debug.WriteLine("Hello WOrld"+ b.ShowtimeId);

            return Content("Hello Ticket not Available");
        }
        public ActionResult Confirmation(string email,int seats,TimeSpan t)
        {
            ViewBag.email = email;
            ViewBag.seats = seats;
            ViewBag.t = t;
            return View();
        }
    }
}