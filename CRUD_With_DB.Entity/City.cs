using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_With_DB.Entity
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; } = "Default City";
        public int CityId {  get; set; }
        //Navigate property
        public State State { get; set; } = new State();

    }
}
