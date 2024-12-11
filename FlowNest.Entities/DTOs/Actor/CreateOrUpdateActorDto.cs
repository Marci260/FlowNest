using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNest.Entities.DTOs.Actor
{
    public class CreateOrUpdateActorDto
    {
        public string Name { get; set; } = "";

        public DateTime Birthdate { get; set; } = DateTime.Now;
    }
}
