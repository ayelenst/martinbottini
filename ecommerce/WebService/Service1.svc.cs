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
    }
}
