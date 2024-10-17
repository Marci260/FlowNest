using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    public class Movie
    {
        //class for mive entity, with id, title,year, genre,director, rating
        [StringLength(50)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public int ReleasedDate { get; set; }
        public Genre Genre { get; set; }
        public string Director { get; set; }
        [NotMapped]
        public virtual ICollection<Rating>? Ratings { get; set; }
        // constructor
        public Movie(string title, int releasedDate, Genre genre, string director)
        {
            Id = System.Guid.NewGuid().ToString();
            Title = title;
            ReleasedDate = releasedDate;
            Genre = genre;
            Director = director;
        }
        //empty constructor
        public Movie()
        {
        }
    }
}
