using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNest.Entities.DTOs.Rating
{
    public class RatingViewDto
    {
        public string Text { get; set; } = "";
        public int Rate { get; set; }
        public string UserFullName { get; set; } = "";
    }
}
