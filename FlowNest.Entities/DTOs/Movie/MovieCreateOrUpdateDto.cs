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

        public  IEnumerable<Genre>? Genre { get; set; }

        public string Director { get; set; } = "";

        //public byte[] Image { get; set; } = new byte[0];
    }
}
