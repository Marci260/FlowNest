using FlowNest.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNest.Entities.DTOs.Movie
{
    public class MovieCreateOrUpdateDto
    {
        public required string Title { get; set; } = "";

        public  Genre genre { get; set; } = Genre.Action;
    }
}
