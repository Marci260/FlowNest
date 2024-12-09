using FlowNest.Entities.DTOs.Rating;
using FlowNest.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNest.Entities.DTOs.Movie
{
    public class MovieViewDto
    {
        public string Id { get; set; } = "";
        public string Title { get; set; } = "";
        public IEnumerable<Genre>? Genres { get; set; }
        public IEnumerable<RatingViewDto>? Ratings { get; set; }

        //extra property
        public int RatingCount => Ratings?.Count() ?? 0;

        public double AverageRating => Ratings?.Count() > 0 ? Ratings.Average(r => r.Rate) : 0;
    }
}
