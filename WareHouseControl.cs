using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace lab4
{
    public partial class WareHouseControl : UserControl
    {
        ProductList productList;
        public WareHouseControl(ProductList productList)
        {
            InitializeComponent();
            this.productList = productList;
        }

        private void GameRadioBtn_Click(object sender, EventArgs e)
        {
            productDataGrid.DataSource = productList.BindingProduktList.OfType<ComputerGame>().ToList();
            BookRadioBtn.Checked = false;
            MovieRadioBtn.Checked = false;
            plattfromTextBox.Enabled = true;
            PlattfromLabel.Enabled = true;
            writerLabel.Enabled = false;
            WriterTextBox.Enabled = false;
            GenreLabel.Enabled = false;
            GenreTextBox.Enabled = false;
            labelLanguage.Enabled = false;
            LanguageTextBox.Enabled = false;
            formatLabel.Enabled = false;
            FormatTextBox.Enabled = false;
            lengthLabel.Enabled = false;
            LengthTextBox.Enabled = false;
        }

        private void BookRdaioBtn_Click(object sender, EventArgs e)
        {
            productDataGrid.DataSource = productList.BindingProduktList.OfType<Book>().ToList();

            GameRadioBtn.Checked = false;
            MovieRadioBtn.Checked = false;
            writerLabel.Enabled = true;
            WriterTextBox.Enabled = true;
            GenreLabel.Enabled = true;
            GenreTextBox.Enabled = true;
            formatLabel.Enabled = true;
            FormatTextBox.Enabled = true;
            labelLanguage.Enabled = true;
            LanguageTextBox.Enabled = true;
            PlattfromLabel.Enabled = false;
            plattfromTextBox.Enabled = false;
            lengthLabel.Enabled = false;
            LengthTextBox.Enabled = false;
        }

        private void MovieRadioBtn_Click(object sender, EventArgs e)
        {
            productDataGrid.DataSource = productList.BindingProduktList.OfType<Movie>().ToList();

            MovieRadioBtn.Checked = true;
            BookRadioBtn.Checked = false;
            GameRadioBtn.Checked = false;
            formatLabel.Enabled = true;
            FormatTextBox.Enabled = true;
            lengthLabel.Enabled = true;
            LengthTextBox.Enabled = true;
            writerLabel.Enabled = false;
            WriterTextBox.Enabled = false;
            GenreLabel.Enabled = false;
            GenreTextBox.Enabled = false;
            labelLanguage.Enabled = false;
            LanguageTextBox.Enabled = false;
            PlattfromLabel.Enabled = false;
            plattfromTextBox.Enabled = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int quanitity = 0;

            if (IdTextBok.Text != "" || NameTextBox.Text != "" || priceTextBox.Text != "")
            {

               if(!IdTextBok.Text.All(Char.IsDigit) || !priceTextBox.Text.All(char.IsDigit)) 
                {
                    MessageBox.Show("Id or Price should only contains positive numbers");
                    return;
                }


                Product item = productList.BindingProduktList.SingleOrDefault(p => p.id == int.Parse(IdTextBok.Text));
                if (item == null || IdTextBok.Text != item.id.ToString())
                {
                    if (BookRadioBtn.Checked && IdTextBok.Text.StartsWith("1"))
                    {
                        Book book = new Book(int.Parse(IdTextBok.Text), quanitity, NameTextBox.Text, int.Parse(priceTextBox.Text),
                            GenreTextBox.Text, FormatTextBox.Text, LanguageTextBox.Text);
                        productList.BindingProduktList.Add(book);
                    }
                    else if (GameRadioBtn.Checked && IdTextBok.Text.StartsWith("2"))
                    {
                        ComputerGame game = new ComputerGame(int.Parse(IdTextBok.Text), quanitity, NameTextBox.Text, int.Parse(priceTextBox.Text), FormatTextBox.Text);
                        productList.BindingProduktList.Add(game);
                    }
                    else if (MovieRadioBtn.Checked && IdTextBok.Text.StartsWith("3"))
                    {
                        Movie movie = new Movie(int.Parse(IdTextBok.Text), quanitity, NameTextBox.Text, int.Parse(priceTextBox.Text), FormatTextBox.Text, LengthTextBox.Text);
                        productList.BindingProduktList.Add(movie);
                    }
                    else
                    {
                        MessageBox.Show("Choose a product category and choose the right id for the right category!");
                    }
                }
                else
                {
                    MessageBox.Show("product id already exist");
                }
            }
            else
            {
                MessageBox.Show("var vänlig och fyll i alla obligatoriska fält(*)");
            }
            update();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (productDataGrid.SelectedRows.Count > 0)
            {
                var item = (Product)productDataGrid.SelectedRows[0].DataBoundItem;
                productList.RemoveProduct(item.id);
                update();
            }
            else
            {
                MessageBox.Show("Var vänlig och välja en produkt");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            productList.SaveFile();
            Application.Exit();
        }

        private void mainContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addProduktBtn_Click(object sender, EventArgs e)
        {
            addProductForm addProductForm = new addProductForm(productList);
            addProductForm.ShowDialog();
            update();



        }

        private void update()
        {
            if (BookRadioBtn.Checked) productDataGrid.DataSource = productList.BindingProduktList.OfType<Book>().ToList();
            else if (GameRadioBtn.Checked) productDataGrid.DataSource = productList.BindingProduktList.OfType<ComputerGame>().ToList();
            else if (MovieRadioBtn.Checked) productDataGrid.DataSource = productList.BindingProduktList.OfType<Movie>().ToList();
        }

        private void IdTextBok_TextChanged(object sender, EventArgs e)
        {

        }
    }
        
}
