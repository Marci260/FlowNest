namespace FlowNest.Models
{
    public class Genre
    {
        //class for genre entity, with id, name
        public string Id { get; set; }
        public string Name { get; set; }
        //constructor
        public Genre( string name)
        {
            Id = System.Guid.NewGuid().ToString();
            Name = name;
        }
        //empty constructor
        public Genre()
        {
        }

    }
}
