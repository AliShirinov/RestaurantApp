using RestaurantOrder.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrder.Models
{
    public static class DbContext
    {
        static DbContext()
        {
            Restaurants = new DbSet<Restaurant>();
        }
        public static DbSet<Restaurant> Restaurants { get; set; }
    }
}
