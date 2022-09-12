using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class addProductForm : Form
    {
        ProductList ProductList;
        public addProductForm(ProductList productList)
        {
            InitializeComponent();
            ProductList = productList;
        }

        private void addProductForm_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(IdTextBox != null)
            {
                foreach(Product p in ProductList.BindingProduktList)
                {
                    if(IdTextBox.Text == p.id.ToString())
                    {
                        var itemIndex = ProductList.BindingProduktList.IndexOf(p);
                        ProductList.BindingProduktList[itemIndex].kvantitet += int.Parse(countTextBox.Text); 
                    } 
                }
            } 
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
