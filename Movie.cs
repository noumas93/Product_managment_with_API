using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Movie : Product
    {
        public Movie(){}

        public Movie(int id, int kvanitet, string name, int price, string format, string length) : base(id , kvanitet,  name, price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.kvantitet = kvanitet;
            this.format = format;
            this.length = length;
        }
        public override int id { get; set; }
        public override string name { get; set; }
        public override int price { get; set; }
        public override int kvantitet { get; set; }
        public string format { get; set; }
        public string length { get; set; }

        public override string ToString()
        {
            return this.id.ToString() + ";" + this.kvantitet.ToString() + ";" + this.name + ";" + this.price.ToString() + ";" + this.format + ";" +  this.length;
        }
    }
}
