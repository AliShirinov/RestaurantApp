using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrder.Data
{
    public class DbSet<T> where T : class
    {
        private readonly List<T> _db;
        public DbSet()
        {
            _db = new List<T>();
        }

        public void Add(T obj)
        {
            _db.Add(obj);
        }

        public List<T> GetAllData()
        {
            return _db;
        }

       

    }
}
