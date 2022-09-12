using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace lab4
{
    public class ProductList
    {
        private string _fileName = "products.csv";
        public BindingList<Product> BindingProduktList { get; set; }
        public BindingList<Product> DeleveryProduct { get; set; }
        public BindingSource DeleveryListSource { get; set; }
        public BindingSource ProductListSource { get; set; }

        List<Product> ApiProductList { get; set; }

        public ProductList()
        {
            BindingProduktList = new BindingList<Product>();
            DeleveryProduct = new BindingList<Product>();
            DeleveryListSource = new BindingSource();
            ProductListSource = new BindingSource();
            ApiProductList = new List<Product>();

        }

        internal void addDeleviry(Product item)
        {
            Product item2 = this.DeleveryProduct.SingleOrDefault(p => p.id == item.id);
            if (item2 is null)
            {
                Product product = new Product();
                product.id = item.id;
                product.name = item.name;
                product.price = item.price;
                product.kvantitet = 1;
                DeleveryProduct.Add(product);
                DeleveryProduct[DeleveryProduct.IndexOf(product)].kvantitet = 1;
            }
            else
            {
                DeleveryProduct[DeleveryProduct.IndexOf(item2)].kvantitet++;
            }
        }

        public void SaveFile()
        {
            using (var file = File.CreateText(getPath(this._fileName)))
            {
                foreach (var product in BindingProduktList)
                {
                    file.WriteLine(string.Join(";", product), Encoding.Default);
                }
            }
        }

        public void loadData()
        {
            BindingProduktList.Clear();
            try
            {
            WebClient client = new WebClient();
            var text = client.DownloadString("https://hex.cse.kau.se/~jonavest/csharp-api/");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(text);

            foreach (XmlElement item in doc.FirstChild.ChildNodes)
            {
                if (item.Name == "products")
                {
                    Product product = new Product();
                    foreach (XmlNode node in item.ChildNodes)
                    {
                        BindingProduktList.Add((Product)Addproduct(node));
                    }
                }
            }
            }
            catch (Exception ex)
            {
                ex.HelpLink = "https://hex.cse.kau.se/~jonavest/csharp-api/";
            }
        }
    

        private Object Addproduct(XmlNode node)
        {
            Object product = new Object();
            int id = node.ChildNodes[0] != null ? int.Parse(node.ChildNodes[0].InnerText) : 0;
            string name = node.ChildNodes[1] != null ? node.ChildNodes[1].InnerText : "";
            int price = node.ChildNodes[2] != null ? int.Parse(node.ChildNodes[2].InnerText) : 0;
            int stock = node.ChildNodes[3] != null ? int.Parse(node.ChildNodes[3].InnerText) : 0;
   
           if (node.Name == "book")
            {
                string genre = node.ChildNodes[4] != null ? node.ChildNodes[4].InnerText : "";
                string format = node.ChildNodes[5] != null ? node.ChildNodes[5].InnerText : "";
                string language = node.ChildNodes[6] != null ? node.ChildNodes[6].InnerText : "";
                product = new Book(id, stock, name, 
                   price, genre,format, language);
            }
            else if (node.Name == "game")
            {
                string plattform = node.ChildNodes[4].InnerText != null ? node.ChildNodes[4].InnerText : "";

                product = new ComputerGame(id, stock,
                   name, price, plattform);
            } 
            else if (node.Name =="movie")
            {
                string format = node.ChildNodes[4] != null ? node.ChildNodes[4].InnerText : "";
                string playtime = node.ChildNodes[5]!= null ? node.ChildNodes[5].InnerText : "";

                product = new Movie(id, stock, 
                    name, price, format,playtime);
            }
            return product;
        }

        public string getPath(string filenName)
        {
            return Path.GetFullPath(filenName);
        }

        internal void RemoveProduct(int id)
        {
            Product item = this.BindingProduktList.SingleOrDefault(p => p.id == id);
            int itemIndex = this.BindingProduktList.IndexOf(item);
            if(item.kvantitet == 0 && this.BindingProduktList.Count >= 0)
            {
                var cust = BindingProduktList.Where(x => x.id.Equals(id));
                BindingProduktList.Remove(cust.First());
            }
            else
            {
                BindingProduktList[itemIndex].kvantitet -= 1;
                if(BindingProduktList[itemIndex].kvantitet == 0)
                {
                    RemoveProduct(id);
                }
            }
        }
        
    }
}
