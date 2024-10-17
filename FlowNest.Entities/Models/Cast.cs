using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNest.Entities.Models
{
    public class Cast
    {
        //class for cast entity, with movieID, actorID, Role
        public int MovieID { get; set; }
        public int ActorID { get; set; }
        public string Role { get; set; }
        //constructor
        public Cast(int movieID, int actorID, string role)
        {
            MovieID = movieID;
            ActorID = actorID;
            Role = role;
        }
        //empty constructor
        public Cast()
        {
        }
    }
}
