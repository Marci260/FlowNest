using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNest.Entities.DTOs.Movie
{
    public class MovieShortViewDto
    {
        public string Id { get; set; } = "";

        public string Title { get; set; } = "";

        public string Genre { get; set; } = "";

        public double AverageRating { get; set; } = 0;
    }
}
