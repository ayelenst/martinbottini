using ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecommerce.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            var app = new ServiceReference.ContractClient();
            var categories = app.GetAllCategories().Where(x=>x.Enabled);

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