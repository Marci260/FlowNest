namespace FlowNest.Models
{
    public class Actor
    {
        //class for actor entity, with id, name, birthdate
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        //constructor
        public Actor(int id, string name, DateTime birthdate)
        {
            Id = id;
            Name = name;
            Birthdate = birthdate;
        }
        //empty constructor
        public Actor()
        {
        }

    }
}
