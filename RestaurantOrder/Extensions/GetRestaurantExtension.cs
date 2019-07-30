using RestaurantOrder.Data;
using RestaurantOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrder.Extensions
{
    public static class GetRestaurantExtension
    {
        public static Restaurant GetRestaurantById(this DbSet<Restaurant> res,int id)
        {
            Restaurant restaurant = null;

            foreach(Restaurant _restaurant in res.GetAllData())
            {
                if(_restaurant.Id == id)
                {
                    restaurant = _restaurant;
                    break;
                }
            }
            return restaurant;
        }

        //Refacter this function
        public static int GetLastProductOfRestaurant(this Restaurant res)
        {
            int counter = 0;
            int productid = 0;

            foreach (Product item in res.Products)
            {
                if(counter == res.Products.Count - 1)
                {
                    productid = item.Id;
                }
                counter++;
            }
            return productid;
        }
    }
}
