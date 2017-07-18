using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EcommerceContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Feature> Feature { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public EcommerceContext()
        {
            Configuration.ProxyCreationEnabled = false;
        }
    }
}
