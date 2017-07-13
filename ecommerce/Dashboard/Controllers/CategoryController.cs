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
            var model = new Category(categoryClient);
            //var model = new Category
            //{
            //    Id = categoryClient.Id,
            //    Name = categoryClient.Name,
            //    Description = categoryClient.Description,
            //    Level = categoryClient.Level,
            //    ParentId = categoryClient.ParentId,
            //    Enabled = categoryClient.Enabled

            //};
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
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


        [HttpPost]
        public ActionResult Edit(Category category)
        {
            var app = new ServiceReference.ContractClient();

            var model = new ServiceReference.Category
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Level = category.Level,
                ParentId = category.ParentId,
                Enabled = category.Enabled
            };

            app.UpdateCategory(model);

            return RedirectToAction("GetById", new { id= category.Id});
        }


        [HttpGet]
        public ActionResult Add()
        {
            var app = new ServiceReference.ContractClient();

            var model = new Category();
            return View(model);
        }


        //[HttpPost]
        //public ActionResult Add(Category category)
        //{
        //    var app = new ServiceReference.ContractClient();

        //    var model = new ServiceReference.Category
        //    {
        //        Id = category.Id,
        //        Name = category.Name,
        //        Description = category.Description,
        //        Level = category.Level,
        //        ParentId = category.ParentId,
        //        Enabled = category.Enabled
        //    };



        //}










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
                    Description = c.Description
                };
                
                model.Add(cat);
            }
            return View(model);
        }
    }
}