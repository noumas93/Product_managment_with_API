using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace lab4
{
    public partial class CashierControl : UserControl
    {
        ProductList productList;

        public CashierControl(ProductList productList)
        {
            InitializeComponent();
            this.productList = productList;
            productDataGrid.DataSource = productList.BindingProduktList;

        }

        private void mainContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleveryBtn_Click(object sender, EventArgs e)
        {
            var item = (Product)productDataGrid.SelectedRows[0].DataBoundItem;
            productList.addDeleviry(item);
            productList.RemoveProduct(item.id);

            deleveryDataGrid.DataSource = productList.DeleveryProduct.ToList();
            productDataGrid.DataSource = productList.BindingProduktList.ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SendDeleveryBtn_Click(object sender, EventArgs e)
        {
            productList.DeleveryProduct.Clear();
            deleveryDataGrid.DataSource = productList.DeleveryProduct.ToList();
            MessageBox.Show("varorna är nu skickade till leverans");
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            productList.DeleveryProduct.Clear();
            deleveryDataGrid.DataSource = productList.DeleveryProduct.ToList();
            MessageBox.Show("varorna är nu sålda");
        }

        private void saveExit_Click(object sender, EventArgs e)
        {
            productList.SaveFile();
            Application.Exit();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            productList.loadData();
            productDataGrid.DataSource = productList.BindingProduktList.ToList();
            deleveryDataGrid.DataSource = productList.DeleveryProduct.ToList();
        }
    }
}
