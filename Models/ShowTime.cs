
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ShowTime
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public TimeSpan Showtime { get; set; }
        public int AvailableSeats { get; set; }

        public ShowTime(int id, int movieId, TimeSpan showtime, int availableSeats)
        {
            Id = id;
            MovieId = movieId;
            Showtime = showtime;
            AvailableSeats = availableSeats;
        }
        public ShowTime()
        {

        }
    }
}
