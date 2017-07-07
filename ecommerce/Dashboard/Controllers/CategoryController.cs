using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dashboard.Models;

namespace Dashboard.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult GetById(int id)
        {
            var app = new ServiceReference.ContractClient();
            var categoryClient = app.GetCategoryById(id);

            var model = new Category
            {
                Id = categoryClient.Id,
                Name = categoryClient.Name,
                Description = categoryClient.Description,
                Level = categoryClient.Level,
                ParentId = categoryClient.ParentId,
                Enabled = categoryClient.Enabled

            };
            return View(model);
        }


        public ActionResult GetAll()
        {
            var app = new ServiceReference.ContractClient();
            var categories = app.GetAllCategories();

            var model = new List<Category>();
            foreach (var c in categories)
            {
                var cat = new Category
                {
                    Id = c.Id,
                    Name = c.Name
                };
                model.Add(cat);
            }
            return View(model);
        }
    }
}