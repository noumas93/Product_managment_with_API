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
    public partial class MainForm : Form
    {
        ProductList productList;

        
        public MainForm()
        {
            InitializeComponent();
            productList = new ProductList();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            productList.loadData();

            WareHouseControl wareHouse = new WareHouseControl(productList);
            wareHouse.Dock = DockStyle.Fill;
            WarehousePage.Controls.Add(wareHouse);

            CashierControl cashierControl = new CashierControl(productList);
            cashierControl.Dock = DockStyle.Fill;
            CashierPage.Controls.Add(cashierControl);
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void WarehousePage_Click(object sender, EventArgs e)
        {

        }
    }
}
