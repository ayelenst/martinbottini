using ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecommerce.Controllers
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
                Doomy = "te amo"
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
                    Name = c.Name,
                    Doomy = "te amo"
                };
                model.Add(cat);
            }
            return View(model);
        }

    //    [HttpGet]
    //    public ActionResult Edit()
    //    {
    //        return View();
    //    }
    //    [HttpPost]
    //    public ActionResult Edit(string example)
    //    {
    //        return View();
    //    }

    //    public ActionResult Add()
    //    {
    //        return View();
    //    }

    //    [HttpPost]
    //    public ActionResult Add(string example)
    //    {
    //        return View();
    //    }

    //    [HttpPost]
    //    public ActionResult Delete()
    //    {
    //        return View();
    //    }
    }
}