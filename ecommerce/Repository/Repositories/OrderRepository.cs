using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Repositories
{
   public class OrderRepository
    {
        public List<Order> GetAll()
        {
            using (var db = new EcommerceContext())
            {
                var query = db.Order.OrderBy(x => x.Id);

                return query.ToList();
            }
        }

        public List<Order> GetAllByState(int id)
        {
            using (var db = new EcommerceContext())
            {
                var query = db.Order.Where(x => x.OrderStateId == id);
                return query.ToList();
            }
        }


        public void Update(Order Order)
        {
            using (var db = new EcommerceContext())
            {

                var cat = db.Products.First(x => x.Id == Order.Id);
                db.Entry(cat).CurrentValues.SetValues(Order);
                db.SaveChanges();
            }
        }

        public Order GetById(int id)
        {
            using (var db = new EcommerceContext())
            {
                return db.Order.First(x => x.Id == id);
            }
        }

        public List<Order> GetByDate(DateTime OrderDate)
        {
            using (var db = new EcommerceContext())
            {
                var query =  db.Order.Where(x => x.OrderDate >= OrderDate);

                return query.ToList();
            }
        }

        public List<Order> GetByDateDone(DateTime OrderDate)
        {
            using (var db = new EcommerceContext())
            {

                var query = db.Order.Where(x => x.OrderDate >= OrderDate && (x.OrderStateId == 1 || x.OrderStateId == 2));

                return query.ToList();
            }
        }

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

    }
}
