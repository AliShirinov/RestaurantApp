using RestaurantOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrder.Core
{
    public static class Seed
    {
        public static void Create()
        {
            if(DbContext.Restaurants.GetAllData().Count == 0)
            {
                List<Product> products = new List<Product>()
                {
                    new Product()
                    {
                        Id = 1,
                        Name = "Coca Cola",
                        Value = "litr",
                        Price = 0.8,
                        ProductCategory = "Icki"
                    },
                    new Product()
                    {
                        Id = 2,
                        Name = "Salat",
                        Value = "pors",
                        Price = 1.5,
                        ProductCategory = "Yemek"
                    }
                };

                Restaurant restaurant = new Restaurant()
                {
                    Id = 1,
                    Name = "Kalyon",
                    Products = products,
                    AddedDate = DateTime.Now,
                    Category = "Ailevi Restoran"
                };


                DbContext.Restaurants.Add(restaurant);
            }
        }
    }
}
