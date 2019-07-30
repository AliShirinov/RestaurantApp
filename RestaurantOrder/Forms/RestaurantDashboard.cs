using RestaurantOrder.Core;
using RestaurantOrder.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using RestaurantOrder.Extensions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrder.Forms
{
    public partial class RestaurantDashboard : Form
    {
        public RestaurantDashboard()
        {
            InitializeComponent();

            //Restaurant name lbl
            Restaurant res = Session.WantedToSeeOnNewForm;
            lbl_res.Text = res.Name;

            //FillDGV
            FillDGV();
        }

        private void RestaurantDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.Main.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int productId = Session.WantedToSeeOnNewForm.GetLastProductOfRestaurant();
            Product product = new Product()
            {
                Id = ++productId,
                Name = txbx_name.Text,
                Price = Convert.ToDouble(txbx_price.Text),
                Value = txbx_value.Text,
                ProductCategory = txbx_category.Text
            };

            Session.WantedToSeeOnNewForm.Products.Add(product);
            FillDGV();
        }

        //Functions
        //Filling data grid view
        public void FillDGV()
        {
            dataGridView1.Rows.Clear();
            foreach (Product product in Session.WantedToSeeOnNewForm.Products)
            {
                if (product != null)
                    dataGridView1.Rows.Add(product.Name, product.ProductCategory, product.Price,product.Value, product.Id);
            }
        }

        
    }
}
