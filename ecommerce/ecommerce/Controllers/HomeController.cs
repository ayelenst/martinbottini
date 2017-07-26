using ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecommerce.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var app = new ServiceReference.ContractClient();
            var lastAddedproducts = app.GetProductLastAdded(4);
            var offerproducts = app.GetProductLastOffers(4);

            var model = new HomeViewModel();

            foreach (var c in lastAddedproducts)
            {
                var prod = new ProductViewModel(c);
                prod.Images = app.GetImageByProductId(prod.Id);
                model.LastAddedProduct.Add(prod);
            }

            foreach (var c in offerproducts)
            {
                var prod = new ProductViewModel(c);
                prod.Images = app.GetImageByProductId(prod.Id);
                model.OfferProduct.Add(prod);                
            }
            var banners = app.GetAllBanner();

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