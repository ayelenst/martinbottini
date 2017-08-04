
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
    public class HomeController : BaseController
    {
        private IService _service;
        public HomeController(IService service):base(service)
        {
            _service = service;
        }
        public ActionResult Index()
        {
            var lastAddedproducts = _service.GetProductLastAdded(6);
            var offerproducts = _service.GetProductLastOffers(3);

            var model = new HomeViewModel();

            foreach (var c in lastAddedproducts)
            {
                var prod = new ProductViewModel(c);
                prod.Images = _service.GetImageByProductId(prod.Id);
                model.LastAddedProduct.Add(prod);
            }

            foreach (var c in offerproducts)
            {
                var prod = new ProductViewModel(c);
                prod.Images = _service.GetImageByProductId(prod.Id);
                model.OfferProduct.Add(prod);                
            }
            var banners = _service.GetAllBanner();

            foreach (var b in banners)
            {
                var ban = new BannerViewModel
                {
                    Id = b.Id,
                    ImageUrl = b.ImageUrl,
                    Description = b.Description,
                    Title = b.Title,
                    Url = b.Url,
                };
                model.BannerViewModels.Add(ban);
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