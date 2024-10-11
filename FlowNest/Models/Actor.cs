namespace FlowNest.Models
{
    public class Actor
    {
        //class for actor entity, with id, name, birthdate
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        //constructor
        public Actor( string name, DateTime birthdate)
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
