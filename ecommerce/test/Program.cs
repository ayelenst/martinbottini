using Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EcommerceContext())
            {
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Category: ");
                var name = Console.ReadLine();

                var blog = new Category { Name = name, Id =1};
                db.Categories.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.Categories
                            orderby b.Name
                            select b;

                Console.WriteLine("All Category in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.Write("Enter a name for a new Category: ");
                var nameProd = Console.ReadLine();

                var blogProd = new Product { Name = name, Id = 1, CategoryId = 1 };
                db.Products.Add(blogProd);
                db.SaveChanges();

                // Display all Blogs from the database 
                var queryProd = from b in db.Products
                                orderby b.Name
                            select b;

                Console.WriteLine("All Category in the database:");
                foreach (var item in queryProd)
                {
                    Console.WriteLine(string.Format("ID {0}, Name {1}, category {2}",item.Id,item.Name,item.Category.Name));
                }


                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
