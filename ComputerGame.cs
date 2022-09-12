namespace lab4
{
    internal class ComputerGame : Product
    {
        public ComputerGame() {}

        public ComputerGame(int id, int kvantitet, string name, int price, string platform) : base(id, kvantitet, name, price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.kvantitet = kvantitet;
            this.plattfrom = platform;
        }

        public override int id { get; set; }
        public override string name { get; set; }
        public override int price { get; set; }
        public  override int kvantitet { get; set; }
        public string plattfrom { get; set; }

        public override string ToString()
        {
            return this.id.ToString() + ";" + this.kvantitet.ToString() + ";" +  this.name + ";" + this.price.ToString() + ";" + this.plattfrom;
        }
    }
}