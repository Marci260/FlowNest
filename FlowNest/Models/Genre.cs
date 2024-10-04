namespace FlowNest.Models
{
    public class Genre
    {
        //class for genre entity, with id, name
        public int Id { get; set; }
        public string Name { get; set; }
        //constructor
        public Genre(int id, string name)
        {
            Id = id;
            Name = name;
        }
        //empty constructor
        public Genre()
        {
        }

    }
}
