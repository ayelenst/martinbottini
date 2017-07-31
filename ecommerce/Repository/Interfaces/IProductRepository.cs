using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
         public interface IProductRepository : IRepository<Product>
    {
         List<Product> GetByCategory(int id, bool requireOffer);

         List<Product> GetAllVisible();



         List<Product> GetLastOffers(int? count);

         List<Product> GetLastAdded(int count);

        void UpdateFull(Product model);
    }
}
