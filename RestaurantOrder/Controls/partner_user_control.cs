using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantOrder.Forms;
using RestaurantOrder.Extensions;
using RestaurantOrder.Models;
using RestaurantOrder.Core;

namespace RestaurantOrder
{
    public partial class partner_user_control : UserControl
    {
        public partner_user_control()
        {
            InitializeComponent();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int resId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            Restaurant selectedRestaurant = DbContext.Restaurants.GetRestaurantById(resId);
            Session.WantedToSeeOnNewForm = selectedRestaurant;


            RestaurantDashboard restaurantDashboard = new RestaurantDashboard();
            Session.Main.Hide();
            restaurantDashboard.ShowDialog();
        }
    }
}
