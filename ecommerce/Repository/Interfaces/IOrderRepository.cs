using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        void Place(Order Order, List<OrderProduct> products);
        void UpdateOrderStatus(int id, int orderStateId);
        Order GetOrderWithProducts(int id);
        void GetReports(out Dictionary<string, double> sellsPerMonth, out Dictionary<string, double> productBestCount, out Dictionary<string, double> productBestSell, out Dictionary<string, Dictionary<string, double>> totalSells);
    }
}
