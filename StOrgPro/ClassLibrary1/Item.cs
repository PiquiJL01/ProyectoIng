using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Item
    {
        public class Item
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Brand { get; set; }
            public string Model { get; set; }

            public Item(int id, string name, string brand, string model)
            {
                ID = id;
                Name = name;
                Brand = brand;
                Model = model;
            }
        }
    }
}
