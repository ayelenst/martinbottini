using WebApplication.Areas.Ecommerce.Models;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Areas.Ecommerce.Controllers
{
    public class ProductController : BaseController
    {
        private IService _service;
        public ProductController(IService service):base(service)
        {
            _service = service;
        }

        public ActionResult QuickView(int id)
        {
            var productClient = _service.GetProductById(id);

            var model = new ProductViewModel(productClient);

            model.Images = _service.GetImageByProductId(id);
            if (model.Images == null)
            {
                model.Images = new List<Image>();
            }

            var categories = ViewBag.LayoutModel as List<CategoryViewModel>;
            model.CategoryName = categories.FirstOrDefault(x => x.Id == model.CategoryId).Name;

            return PartialView("ViewProduct",model);
        }

        public ActionResult GetById(int id)
        {
            var productClient = _service.GetProductById(id);

            var model = new ProductViewModel(productClient);

            model.Images = _service.GetImageByProductId(id);
            if (model.Images == null)
            {
                model.Images = new List<Image>();
            }

            var categories = ViewBag.LayoutModel as List<CategoryViewModel>;
            model.CategoryName = categories.FirstOrDefault(x => x.Id == model.CategoryId).Name;

            model.Feature = _service.GetFeatureByProductId(model.Id).Select(x => new FeatureViewModel
            {
                Id = x.Id,
                Description = x.Description,
                Name = x.Name
            }).ToList();

            return View(model);
        }
    }
}