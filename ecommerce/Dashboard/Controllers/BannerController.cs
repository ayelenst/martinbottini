using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dashboard.Models;

namespace Dashboard.Controllers
{
    public class BannerController : Controller
    {
        public ActionResult GetAll()
        {
            var app = new ServiceReference.ContractClient();
            var banner = app.GetAllBanner();

            var model = new List<BannerViewModel>();
            foreach (var c in banner)
            {
                var cat = new BannerViewModel
                {
                    Id = c.Id,
                    ImageUrl = c.ImageUrl,
                    Title = c.Title,
                    Description = c.Description,
                    Url = c.Url,
                };
                model.Add(cat);
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var app = new ServiceReference.ContractClient();
            var BannerClient = app.GetBannerById(id);

            var model = new BannerViewModel
            {
                Id = BannerClient.Id,
                ImageUrl = BannerClient.ImageUrl,
                Description = BannerClient.Description,
                Title = BannerClient.Title,
                Url = BannerClient.Url,
            };
            return View(model);
        }


        [HttpPost]
        public ActionResult Edit(BannerViewModel banner)
        {
            var app = new ServiceReference.ContractClient();

            var model = new ServiceReference.Banner
            {
                Id = banner.Id,
                ImageUrl = banner.ImageUrl,
                Description = banner.Description,
                Title = banner.Title,
                Url = banner.Url,
            };

            app.UpdateBanner(model);

            return RedirectToAction("GetAll");
        }


        [HttpGet]
        public ActionResult Add()
        {
            var app = new ServiceReference.ContractClient();

            var model = new BannerViewModel();
            return View(model);
        }


        [HttpPost]
        public ActionResult Add(BannerViewModel banner)
        {
            var app = new ServiceReference.ContractClient();

            var model = new ServiceReference.Banner
            {
                Id = banner.Id,
                ImageUrl = banner.ImageUrl,
                Description = banner.Description,
                Title = banner.Title,
                Url = banner.Url,
            };
            app.AddBanner(model);

            return RedirectToAction("GetAll");

        }

        public ActionResult Delete(int id)
        {
            var app = new ServiceReference.ContractClient();
            app.DeleteBanner(id);
            return RedirectToAction("GetAll");
        }

    }
}