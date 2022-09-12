using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab4
{
    class Book : Product
    {
        public Book(){}

        public Book(int id, int kvantitet, string name, int price, string genre,string format, string Language) : base(id, kvantitet, name, price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.kvantitet = kvantitet;
            this.Genre = genre;
            this.Format = format;
            this.Language = Language;
   
        }
        public override int id { get; set; }
        public override string name { get; set; }
        public override int price { get; set; }
        public override int kvantitet {  get;  set; }
        public string Genre { get; set; }
        public string Format { get; set; }
        public string Language { get; set; }

        public override string ToString()
        {
            return this.id.ToString() + ";" + this.kvantitet.ToString() + ";" + this.name + ";" + this.price.ToString() +  ";" + this.Genre + ";" + this.Format + ";" + this.Language;
        }

    }
}
