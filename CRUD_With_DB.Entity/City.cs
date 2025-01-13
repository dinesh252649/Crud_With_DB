namespace CRUD_With_DB.Entity
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; } = "Default City";
        public int StateIdd { get; set; }
        //Navigate property
        public State State { get; set; } //= new();

    }
}
