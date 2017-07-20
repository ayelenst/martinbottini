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

            var model = new ProductViewModel
            {
                Id = productClient.Id,
                Name = productClient.Name,
                Description = productClient.Description,
                Enabled = productClient.Enabled,
                IsOffer = productClient.IsOffer,
                Percent = productClient.Percent,
                Price = productClient.Price,
                StartDay = productClient.StartDay,
                EndDay = productClient.EndDay,
                Images = productClient.Image,
                CategoryId = productClient.CategoryId
            };           

            model.Images = app.GetImageByProductId(id);
            if (model.Images == null)
            {
                model.Images = new List<ServiceReference.Image>();
            }
            return PartialView("ViewProduct",model);
        }
    }
}