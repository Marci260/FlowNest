using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNest.Entities.Models
{
    public  class Show
    {
        //class for show entity, with id, title, year, genre, rating
        public string Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        //full constructor
        public Show(string title, int year, string genre, int rating)
        {
            Id = System.Guid.NewGuid().ToString();
            Title = title;
            Year = year;
            Genre = genre;
            Rating = rating;
        }
        //empty constructor
        public Show()
        {
        }
    }
}
