using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belshifa
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Usage { get; set; }
        public int Price { get; set; }

        public Product(int id, string name, string usage, int price)
        {
            ID = id;
            Name = name;
            Usage = usage;
            Price = price;
        }

        public Product()
        {
        }

    }
}
