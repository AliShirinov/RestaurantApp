using RestaurantOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrder.Core
{
    public static class Session
    {
        public static Form Main { get; set; }
        public static Restaurant WantedToSeeOnNewForm { get; set; }
    }
}
