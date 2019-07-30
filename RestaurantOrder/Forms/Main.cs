using RestaurantOrder.Controls;
using RestaurantOrder.Core;
using RestaurantOrder.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Re Design
            ReDesign(home_user_control1, btn_home, side_panel);

            //Seed Functionality
            Seed.Create();

            //Fill data grid view
            FillDGV();


            //Add Form to Session
            Session.Main = this;
        }

        private void btn_partner_Click(object sender, EventArgs e)
        {
            ReDesign(partner_user_control1, btn_partner, side_panel);
        }

        //Events
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Functions
        public void ReDesign(UserControl control, Button btn, Panel panel)
        {
            panel.Top = btn.Top;
            panel.Height = btn.Height;
            control.BringToFront();
        }



        //Filling data grid view
        public void FillDGV()
        {
            partner_user_control1.dataGridView1.Rows.Clear();
            foreach (Restaurant restaurant in DbContext.Restaurants.GetAllData())
            {
                if(restaurant != null)
                partner_user_control1.dataGridView1.Rows.Add(restaurant.Name, restaurant.Category, restaurant.AddedDate, restaurant.Id);
            }
        }

        
    }
}
