using FlowNest.Entities.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace FlowNest.Entities.Models
{

    public enum Genre
    {
        Action,
        Adventure,
        Comedy,
        Crime,
        Drama,
        Fantasy,
        Historical,
        Horror,
        Mystery,
        Romance,
        ScienceFiction,
        Thriller,
        Western
    }
    public class Movie : IIdEntity
    {
        //class for mive entity, with id, title,year, genre,director, rating
        [StringLength(50)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public DateTime ReleasedDate { get; set; }
        public IList<Genre> Genres { get; set; }
        public string Director { get; set; }
        [NotMapped]
        public virtual ICollection<Rating>? Ratings { get; set; }
        // constructor
        public Movie(string title, IList<Genre> genres, string director)
        {
            Id = System.Guid.NewGuid().ToString();
            Title = title;
            ReleasedDate = System.DateTime.Now;
            Genres = genres;
            Director = director;
        }
        //empty constructor
        public Movie()
        {
        }
    }
}
