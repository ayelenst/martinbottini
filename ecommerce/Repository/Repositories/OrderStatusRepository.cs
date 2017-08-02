using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class OrderStatusRepository : Repository<OrderStatus>, IOrderStatusRepository
    {
        public OrderStatusRepository(EcommerceContext context) : base(context) { }

    }
}
