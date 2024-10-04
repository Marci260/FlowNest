namespace FlowNest.Models
{
    
    public class Movie
    {
        //class for mive entity, with id, title,year, genre,director, rating
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public int Rating { get; set; }
        // constructor
        public Movie(int id, string title, int year, string genre, string director, int rating)
        {
            Id = id;
            Title = title;
            Year = year;
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
