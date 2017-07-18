using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class  ProductRepository
    {
        public List<Product> GetAll()
        {
            using (var db = new EcommerceContext())
            {
                var query = db.Products.OrderBy(x => x.Id);
                return query.ToList();
            }
        }

        public List<Product> GetWithOffer()
        {
            using (var db = new EcommerceContext())
            {
                var query = db.Products.Where(x => x.IsOffer == true);
                return query.ToList();
            }
        }


        public List<Product> GetByCategory(int id)
        {
            using (var db = new EcommerceContext())
            {
                var query = db.Products.Where(x => x.CategoryId == id);
                var query2 = db.Products.Where(x => x.Category.ParentId == id);
                var children = db.Categories.Where(x => x.ParentId == id);
                var query3 = new List<Product>();

                foreach (var child in children)
                {
                    query3.AddRange(db.Products.Where(x => x.Category.ParentId == child.Id).ToList());
                }
                query3.AddRange(query2.ToList());
                query3.AddRange(query.ToList());
                return query3;
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


        public List<Product> GetByName(string name)
        {
            using (var db = new EcommerceContext())
            {
                var query = db.Products.Where(x => x.Name.Contains(name) || x.Description.Contains(name));
                return query.ToList();
            }
        }

        public Product GetById(int id)
        {
            using (var db = new EcommerceContext())
            {
                var questions = db.Products.Include("Feature").Select(q => q).ToList();

                var product = questions.First(x => x.Id == id);
                return product;
            }
        }

        public void Add(Product Product)
        {
            using (var db = new EcommerceContext())
             {
                db.Products.Add(Product);
                db.SaveChanges();
            }
        }

        public void Update(Product Product)
        {
            using (var db = new EcommerceContext())
            {

                var cat = db.Products.First(x => x.Id == Product.Id);
                db.Entry(cat).CurrentValues.SetValues(Product);
                db.SaveChanges();
            }
        }


        public void Delete(int id)
        {
            using (var db = new EcommerceContext())
            {

                var cat = db.Products.First(x => x.Id == id);
                db.Products.Remove(cat);
                db.SaveChanges();
            }
        }

    }
}
