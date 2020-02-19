using System;
using System.Collections.Generic;
using System.Text;

namespace TommySimCore
{
    class City
    {
        public int Water { get; set; }
        public int Wood { get; set; }

        public List<Person> Villagers = new List<Person>();

        public City()
        {
            Water = 10;
        }
    }
}
