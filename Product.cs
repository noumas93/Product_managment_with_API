namespace lab4
{
    public class Product
    {
        public Product(int id, int kvantitet, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.kvantitet = kvantitet;
        }
       
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual int price { get; set; }
        public virtual int kvantitet { get; set; }

        public Product(){}

    }
}