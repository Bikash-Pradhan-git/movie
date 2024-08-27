using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int ShowtimeId { get; set; }
        public int NumberOfSeats { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}