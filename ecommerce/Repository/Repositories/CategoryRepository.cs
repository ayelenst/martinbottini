using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CategoryRepository
    {

        public List<Category> GetAll()
        {
            using (var db = new EcommerceContext())
            {
                var query = db.Categories.OrderBy(x => x.Id);

                return query.ToList();
            }
        }

        public List<Category> GetAllVisible()
        {
            using (var db = new EcommerceContext())
            {
                var query = db.Categories.Where(x => x.Enabled == true);
                return query.ToList();
            }
        }

        public Category GetById(int id)
        {
            using (var db = new EcommerceContext())
            {
                return db.Categories.First(x => x.Id == id);
            }
        }




        public void Add(Category category)
        {
            using (var db = new EcommerceContext())
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
        }

        public void Update(Category category)
        {
            using (var db = new EcommerceContext())
            {

                var cat = db.Categories.First(x => x.Id == category.Id);
                db.Entry(cat).CurrentValues.SetValues(category);
                db.SaveChanges();
            }
        }

        public void Delete(Category category)
        {
            using (var db = new EcommerceContext())
            {

                var cat = db.Categories.First(x => x.Id == category.Id);
                db.Categories.Remove(cat);
                db.SaveChanges();
            }
        }

    }
}
