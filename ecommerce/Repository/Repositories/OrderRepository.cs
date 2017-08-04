using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Repositories
{
   public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private static string[] Months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        private static string[] Days = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };

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

        public void GetReports(out Dictionary<string, double> sellsPerMonth, out Dictionary<string, double> productBestCount, out Dictionary<string, double> productBestSell, out Dictionary<string, Dictionary<string, double>> totalSells)
        {
            var datetime = DateTime.Now.AddYears(-1);
            var sellsPerMonth1 = Context.Order.Where(x => x.OrderStatusId == 3 && x.OrderDate >= datetime).OrderBy(x => x.OrderDate).GroupBy(x => x.OrderDate.Month);
            sellsPerMonth = new Dictionary<string, double>();
            foreach (var s in sellsPerMonth1.OrderBy(x=>x.Key))
            {
                sellsPerMonth.Add(Months[s.Key-1], s.Sum(y => y.Total));
            }
           

            var allProducts = Context.Order.Include("OrderProducts").Where(x=>x.OrderStatusId==3).SelectMany(x => x.OrderProduct);

            var productBestSell1 = allProducts.GroupBy(x => x.NameProduct);
            var productBestSell2 = new Dictionary<string, double>();
            foreach (var s in productBestSell1)
            {
                productBestSell2.Add(s.Key, s.Sum(y => y.Price * y.Quantity));
            }          
            
            productBestSell = GetDictioaryBestFive(productBestSell2);


             var productBestCount1 = allProducts.GroupBy(x => x.NameProduct);

            var productBestCount2 = new Dictionary<string, double>();
            foreach (var s in productBestSell1)
            {
                productBestCount2.Add(s.Key, s.Sum(y => y.Quantity));
            }

            productBestCount = GetDictioaryBestFive(productBestCount2);



            totalSells = new Dictionary<string, Dictionary<string, double>>();
              CultureInfo german = new CultureInfo("es-ES");
          
            for (int i = 0; i<7; i++)
            {
                var minDate = DateTime.Today.AddDays(-i);
                var maxDate = DateTime.Today.AddDays(-i+1);
                var sellsToday1 = Context.Order.Include("OrderStatus").Where(x => x.OrderDate >= minDate && x.OrderDate<=maxDate).GroupBy(x => x.OrderStatus.Name);

                var sellsToday2 = new Dictionary<string, double>();
                if(sellsToday1.Any(x=>x.Key == "Cancelada"))
                {
                    var s = sellsToday1.FirstOrDefault(x => x.Key == "Cancelada");
                    sellsToday2.Add(s.Key, s.Sum(y => y.Total));
                }
                else
                {
                    sellsToday2.Add("Cancelada", 0);
                }
                if (sellsToday1.Any(x => x.Key == "Cerrada"))
                {
                    var s = sellsToday1.FirstOrDefault(x => x.Key == "Cerrada");
                    sellsToday2.Add(s.Key, s.Sum(y => y.Total));
                }
                else
                {
                    sellsToday2.Add("Cerrada", 0);
                }
                if (sellsToday1.Any(x => x.Key == "PendienteEnvio"))
                {
                    var s = sellsToday1.FirstOrDefault(x => x.Key == "PendienteEnvio");
                    sellsToday2.Add(s.Key, s.Sum(y => y.Total));
                }
                else
                {
                    sellsToday2.Add("PendienteEnvio", 0);
                }

                
                totalSells.Add(german.DateTimeFormat.DayNames[(int)DateTime.Now.AddDays(-i).DayOfWeek], sellsToday2);
            }
            

        }

        private Dictionary<string, double> GetDictioaryBestFive (Dictionary<string, double> dic)
        {
            var total = dic.Sum(x => x.Value);
            var result = dic.OrderByDescending(x => x.Value).Take(5).ToDictionary(x => x.Key, x => x.Value);
            var subtotal = result.Sum(x => x.Value);
            result.Add("Others", total - subtotal);
            return result;
        }
    }
}
