using ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecommerce.Controllers
{
    public class ProductController : BaseController
    {
        public ActionResult QuickView(int id)
        {
            var app = new ServiceReference.ContractClient();
            var productClient = app.GetProductById(id);

            var model = new ProductViewModel(productClient);

            model.Images = app.GetImageByProductId(id);
            if (model.Images == null)
            {
                model.Images = new List<ServiceReference.Image>();
            }

            var categories = ViewBag.LayoutModel as List<CategoryViewModel>;
            model.CategoryName = categories.FirstOrDefault(x => x.Id == model.CategoryId).Name;

            return PartialView("ViewProduct",model);
        }

        public ActionResult GetById(int id)
        {
            var app = new ServiceReference.ContractClient();
            var productClient = app.GetProductById(id);

            var model = new ProductViewModel(productClient);

            model.Images = app.GetImageByProductId(id);
            if (model.Images == null)
            {
                model.Images = new List<ServiceReference.Image>();
            }

            var categories = ViewBag.LayoutModel as List<CategoryViewModel>;
            model.CategoryName = categories.FirstOrDefault(x => x.Id == model.CategoryId).Name;

            model.Feature = app.GetFeatureByProductId(model.Id).Select(x => new FeatureViewModel
            {
                Id = x.Id,
                Description = x.Description,
                Name = x.Name
            }).ToList();

            return View(model);
        }
    }
}