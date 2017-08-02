using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Repositories
{
   public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(EcommerceContext context) : base(context) { }
      

        public void Place(Order Order, List<OrderProduct> products)
        {
            using (var db = new EcommerceContext())
            {
                db.Order.Add(Order);
                db.SaveChanges();
                foreach(var product in products)
                {
                    product.OrderId = Order.Id;
                    db.OrderProduct.Add(product);
                }
                db.SaveChanges();

            }
        }

        public Order GetOrderWithProducts (int id)
        {
            using (var db = new EcommerceContext())
            {
                return db.Order.Include("OrderProduct").FirstOrDefault(x => x.Id == id);

            }
        }

        public void UpdateOrderStatus(int id, int orderStateId)
        {

            var entry = Context.Order.FirstOrDefault(x => x.Id == id);

            entry.OrderStatusId = orderStateId;
           Context.SaveChanges();
        }

    }
}
