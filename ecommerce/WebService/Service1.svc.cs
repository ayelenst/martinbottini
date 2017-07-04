using Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
   
    public class Service1 : IContract
    {

        public List<Category> GetAllCategories()
        {
            using (var db = new EcommerceContext())
            {

                // Display all Blogs from the database 
                var query = db.Categories.OrderBy(x=>x.Id);

                return query.ToList();
            }
        }


        public Category GetCategoryById(int id)
        {
            using (var db = new EcommerceContext())
            {                
                return db.Categories.First(x => x.Id == id);
            }
        }

        public void AddCategory(Category category)
        {
            using (var db = new EcommerceContext())
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
        }

        public void UpdateCategory(Category category)
        {
            using (var db = new EcommerceContext())
            {
               var cat = db.Categories.First(x => x.Id == category.Id);
                cat.Name = category.Name;                
                db.SaveChanges();
            }
        }
    }
}
