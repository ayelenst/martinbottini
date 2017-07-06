using Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dashboard.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}