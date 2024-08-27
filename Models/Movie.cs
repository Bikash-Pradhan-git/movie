using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApplication2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public double Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ShowTime Show { get; set; }

        public Movie(int Id, string Title, string Description, string Genre, double Duration, DateTime ReleaseDate,TimeSpan times,int seat)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.Genre = Genre;
            this.Duration = Duration;
            this.ReleaseDate = ReleaseDate;
            this.Show = new ShowTime(Id, Id, times, seat);

        }
        public Movie()
        {

        }
    }
}