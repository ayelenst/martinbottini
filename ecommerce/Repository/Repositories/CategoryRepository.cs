using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(EcommerceContext context) : base(context) { }

        public List<KeyValuePair<int, int>> GetCategoryCount(bool requireOffer)
        {
            using (var db = new EcommerceContext())
            {
                if(!requireOffer)
                return db.Categories.AsEnumerable().Select(x => new KeyValuePair<int, int>(x.Id,
                    db.Products.Count(y=>y.CategoryId == x.Id || y.Category.ParentId ==x.Id)
                    )).ToList();
                else
                    return db.Categories.AsEnumerable().Select(x => new KeyValuePair<int, int>(x.Id,
                   db.Products.Count(y =>( y.CategoryId == x.Id || y.Category.ParentId == x.Id) && y.IsOffer && x.Enabled && y.StartDay < DateTime.Now && y.EndDay > DateTime.Now)
                   )).ToList();
            }
        }

      
    }
}
