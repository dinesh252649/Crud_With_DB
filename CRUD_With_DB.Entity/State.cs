using System.Collections.Generic;

namespace CRUD_With_DB.Entity
{
    public class State
    {
        public int ID { get; set; }
        public string Name { get; set; } = "Default State";
        public int ContryId { get; set; }// foreign Key
        //Navigation property
        public Countary Countary { get; set; } = new Countary();
        //Navigation property
        public ICollection<City> Citys { get; set; } = new HashSet<City>();

    }
}
