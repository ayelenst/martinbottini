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

        public IDictionary<int, int> GetCategoryCount(bool requireOffer)
        {
            var dictionary = new Dictionary<int, int>();
            var categories = Context.Categories.Include("Products").ToList();
            foreach (var cat in categories.Where(x=>x.Level == 0))
            {
                var count = 0;
                if (!requireOffer)
                {
                    count = cat.Products.Count();
                    var children = categories.Where(x => x.ParentId == cat.Id);
                    foreach(var child in children)
                    {
                        count = count + child.Products.Count();

                    }
                }
                else
                {
                        count = cat.Products.Count(y => y.IsOffer && y.Enabled && y.StartDay < DateTime.Now && y.EndDay > DateTime.Now);
                        var children = categories.Where(x => x.ParentId == cat.Id);
                        foreach (var child in children)
                        {
                        count = count + child.Products.Count(y => y.IsOffer && y.Enabled && y.StartDay < DateTime.Now && y.EndDay > DateTime.Now);

                        
                    }
                }
                dictionary.Add(cat.Id, count);
            }
            return dictionary;
        
          
        }

      
    }
}
