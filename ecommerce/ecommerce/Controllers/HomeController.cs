using ecommerce.Models;
using System;
using System.Collections.Generic;
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

            var lastAddedModel = new List<ProductViewModel>();
            var offerproductsModel = new List<ProductViewModel>();
          
            foreach (var c in lastAddedproducts)
            {
                var prod = new ProductViewModel(c);
                prod.Images = app.GetImageByProductId(prod.Id);
                lastAddedModel.Add(prod);
            }

            foreach (var c in offerproducts)
            {
                var prod = new ProductViewModel(c);
                prod.Images = app.GetImageByProductId(prod.Id);
                offerproductsModel.Add(prod);                
            }
            var banners = app.GetAllBanner();

            foreach (var b in banners)
            {

            }
            //    var model = new BannerViewModel
            //{
            //    Id = BannerClient.Id,
            //    ImageUrl = BannerClient.ImageUrl,
            //    Description = BannerClient.Description,
            //    Title = BannerClient.Title,
            //    Url = BannerClient.Url,
            //};


            return View();

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