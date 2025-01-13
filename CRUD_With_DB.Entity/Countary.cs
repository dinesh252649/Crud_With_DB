using System.Collections.Generic;

namespace CRUD_With_DB.Entity
{
    public class Countary
    {
        public int ID { get; set; }
        public string Name { get; set; } = "Default Countary";
        //Navigation property 
        public ICollection<State> States { get; set; } = new HashSet<State>();

    }
}
