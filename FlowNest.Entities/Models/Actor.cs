using FlowNest.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNest.Entities.Models
{
    public class Actor : IIdEntity
    {

        //class for actor entity, with id, name, birthdate
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        [NotMapped]
        public virtual ICollection<Movie>? Movies { get; set; }

        //constructor
        public Actor(string name, DateTime birthdate)
        {
            Id = System.Guid.NewGuid().ToString();
            Name = name;
            Birthdate = birthdate;
        }
        //empty constructor
        public Actor()
        {
        }
    }
}
