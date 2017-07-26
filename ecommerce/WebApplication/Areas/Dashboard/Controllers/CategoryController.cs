using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Areas.Dashboard.Models;

namespace WebApplication.Areas.Dashboard.Controllers
{
    public class CategoryController : Controller
    {
        private IService _service;
        public CategoryController(IService service)
        {
            _service = service;
        }

        public ActionResult GetAll()
        {
             
            var categories = _service.GetAllCategories();

            var model = new List<CategoryViewModel>();
            foreach (var c in categories)
            {
                var cat = new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Enabled = c.Enabled,
                    Level = c.Level,
                    ParentId = c.ParentId,
                    
                };
                model.Add(cat);
            }

            return View(model);
        }

        public ActionResult GetById(int id)
        {
             
            var categoryClient = _service.GetCategoryById(id);
            var model = new CategoryViewModel(categoryClient);
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
             
            var categoryClient = _service.GetCategoryById(id);

            var model = new CategoryViewModel
            {
                Id = categoryClient.Id,
                Name = categoryClient.Name,
                Description = categoryClient.Description,
                Level = categoryClient.Level,
                ParentId = categoryClient.ParentId,
                Enabled = categoryClient.Enabled

            };
            //obtenemso todas las categorias
            var categoriesClient = _service.GetAllCategories();

            //de todas las categorias, tomamos solo las padre y por cada una generamos un categoryviewmodel
            var completeModel = categoriesClient.Where(x => x.Level == 0).Select(x => new CategoryViewModel(x)).ToList();
           
            model.ParentCategories = completeModel;
            return View(model);
        }


        [HttpPost]
        public ActionResult Edit(CategoryViewModel category)
        {
             

            var model = new Category
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Level = category.Level,
                ParentId = category.ParentId,
                Enabled = category.Enabled
            };
            if (category.ParentId == null) {

                category.ParentId = 0;
            }
            _service.UpdateCategory(model);

            return RedirectToAction("GetAll");
        }


        [HttpGet]
        public ActionResult Add()
        {
             

            var model = new CategoryViewModel();
            //obtenemso todas las categorias
            var categoriesClient = _service.GetAllCategories();

            //de todas las categorias, tomamos solo las padre y por cada una generamos un categoryviewmodel
            var completeModel = categoriesClient.Where(x => x.Level == 0).Select(x => new CategoryViewModel(x)).ToList();

            model.ParentCategories = completeModel;

            return View(model);
        }


        [HttpPost]
        public ActionResult Add(CategoryViewModel category)
        {
             

            var model = new Category
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Level = category.Level,
                ParentId = category.ParentId,
                Enabled = category.Enabled

            };
            if (category.ParentId == null)
            {

                category.ParentId = 0;
            }

            _service.AddCategory(model);

            return RedirectToAction("GetAll");

        }

        public ActionResult Delete(int id)
        {
             
            _service.DeleteCategory(id);
            return RedirectToAction("GetAll");
        }





    }
    
}