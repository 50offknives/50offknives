using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsUI
{
    public partial class Dashboard : Form
    {
        List<Product> products = new List<Product>();

        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            productsFoundListBox.DataSource = products;
            productsFoundListBox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            products = db.GetProducts(productText.Text);

            UpdateBinding();
        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertProduct(modelNumberInsText.Text, manufacturerInsText.Text, descriptionInsText.Text, float.Parse(sizeInsText.Text), typeInsText.Text);

            modelNumberInsText.Text = "";
            manufacturerInsText.Text = "";
            descriptionInsText.Text = "";
            sizeInsText.Text = "";
            typeInsText.Text = "";
        }
    }
}
