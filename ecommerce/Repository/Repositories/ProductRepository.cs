using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class  ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(EcommerceContext context) : base(context) { }    
        


        public List<Product> GetByCategory(int id, bool requireOffer)
        {
            using (var db = new EcommerceContext())
            {
                var query = db.Products.Where(x => x.CategoryId == id || x.Category.ParentId == id);

                if (requireOffer)
                {
                    query.Where(x=>x.IsOffer && x.StartDay < DateTime.Now && x.EndDay > DateTime.Now);
                }
                return query.ToList();
            }
        }

        public List<Product> GetAllVisible()
        {
            using (var db = new EcommerceContext())
            {
                var query = db.Products.Where(x => x.Enabled == true);
                return query.ToList();
            }
        }
        


        public List<Product> GetLastOffers(int? count)
        {
            using (var db = new EcommerceContext())
            {
                var productsInOffer = db.Products.Where(x => x.IsOffer && x.Enabled && x.StartDay<DateTime.Now && x.EndDay>DateTime.Now);
                if (count.HasValue)
                    return productsInOffer.OrderBy(x=>x.EndDay).Take(count.Value).ToList();
                return productsInOffer.ToList();
            }
        }

        public List<Product> GetLastAdded(int count)
        {
            using (var db = new EcommerceContext())
            {
                var productsInOffer = db.Products.Where(x => x.Enabled);
                            
                return productsInOffer.OrderByDescending(x=>x.Id).Take(count).ToList();
            }
        }

    }
}
