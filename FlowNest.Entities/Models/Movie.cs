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
        public string Id { get; set; }
        public string Title { get; set; }
        public int ReleasedDate { get; set; }
        public Genre Genre { get; set; }
        public string Director { get; set; }
        public int Rating { get; set; }
        // constructor
        public Movie(string title, int releasedDate, string genre, string director, int rating)
        {
            Id = System.Guid.NewGuid().ToString();
            Title = title;
            ReleasedDate = releasedDate;
            Genre = genre;
            Director = director;
            Rating = rating;
        }
        //empty constructor
        public Movie()
        {
        }
    }
}
