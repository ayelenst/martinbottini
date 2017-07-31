using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Service;
using Model;
using WebApplication.Areas.Dashboard.Models;

namespace WebApplication.Areas.Dashboard.Controllers
{
    public class BannerController : Controller
    {

        private IService _service;
        public BannerController(IService service)
        {
            _service = service;
        }
        public ActionResult GetAll()
        {
            var banner = _service.GetAllBanner();

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
            var BannerClient = _service.GetBannerById(id);

            var model = new BannerViewModel
            {
                Id = BannerClient.Id,
                ImageUrl = BannerClient.ImageUrl,
                Description = BannerClient.Description,
                Title = BannerClient.Title,
                Url = BannerClient.Url,
            };
            if(model.ImageUrl != string.Empty)
            {
                TempData["ImageUrl"] = model.ImageUrl;
            }
            return View(model);
        }


        [HttpPost]
        public ActionResult Edit(BannerViewModel banner)
        {
            var path = string.Empty;
            if (Request.Files.Count == 1 && Request.Files[0].FileName != string.Empty)
            {               
                path = ImageHelper.SaveImage("Banner", Request.Files[0], Server.MapPath("~/Image"));
            }
            else
            {
                path = TempData["ImageUrl"].ToString();
            }
            var model = new Banner
            {
                Id = banner.Id,
                ImageUrl = path,
                Description = banner.Description,
                Title = banner.Title,
                Url = banner.Url,
            };

            _service.UpdateBanner(model);

            if (Request.Files.Count == 1 && Request.Files[0].FileName != string.Empty)
            {
                var bannerClient = _service.GetBannerById(banner.Id);
                ImageHelper.DeleteImage(bannerClient.ImageUrl);
            }

            return RedirectToAction("GetAll");
        }


        [HttpGet]
        public ActionResult Add()
        {
             

            var model = new BannerViewModel();
            return View(model);
        }


        [HttpPost]
        public ActionResult Add(BannerViewModel banner)
        {
             
            var path = string.Empty;
            if (Request.Files.Count == 1)
            {
                path = ImageHelper.SaveImage("Banner", Request.Files[0], Server.MapPath("~/Image"));                
            }
            var model = new Banner
            {
                Id = banner.Id,
                ImageUrl = path,
                Description = banner.Description,
                Title = banner.Title,
                Url = banner.Url,
            };
            _service.AddBanner(model);

            return RedirectToAction("GetAll");

        }

        public ActionResult Delete(int id)
        {
             
            _service.DeleteBanner(id);
            return RedirectToAction("GetAll");
        }

    }
}