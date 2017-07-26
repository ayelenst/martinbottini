
using Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Areas.Ecommerce.Models;
namespace WebApplication.Areas.Ecommerce.Controllers
{
    public class BaseController : System.Web.Mvc.Controller
    {
        private IService _service;
     

        public BaseController(IService service)
        {
            _service = service;
            var categories = _service.GetAllCategories().Where(x=>x.Enabled);

            var model = new List<CategoryViewModel>();
            foreach (var c in categories)
            {
                var cat = new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Level = c.Level,
                    Parent = c.ParentId,
                    IsEnable = c.Enabled

                };
                cat.CountChildren = categories.Count(x => x.ParentId == cat.Id && x.Level == 1);
                model.Add(cat);
            }

            var imageFolder = ConfigurationManager.AppSettings["imageFolder"];
            ViewBag.imageFolder = imageFolder;
            ViewBag.LayoutModel = model;
        }
    }
}