using ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecommerce.Controllers
{
    public class CategoryController : BaseController
    {
        public ActionResult GetById(int id = 0, bool isOffer = false)
        {
            var app = new ServiceReference.ContractClient();
            var categories = ViewBag.LayoutModel as List<CategoryViewModel>;
            List<ProductViewModel> productsToDisplay;
            if (id == 0)
            {
                if (isOffer)
                {
                    productsToDisplay = app.GetProductLastOffers(8).Select(x => new ProductViewModel(x)).ToList();
                }
                else
                {
                    productsToDisplay = app.GetProductLastAdded(8).Select(x => new ProductViewModel(x)).ToList();
                }
            }
            else
            {

                productsToDisplay = app.GetProductByCategory(id, isOffer).Select(x => new ProductViewModel(x)).ToList();
            }


            var categoriesAmount = app.GetCategoryCount(isOffer);
            foreach (var c in categories)
            {
                c.CountProduct = categoriesAmount.FirstOrDefault(x => x.Key == c.Id).Value;
            }

            foreach (var c in productsToDisplay)
            {
                c.Images = app.GetImageByProductId(c.Id);
            }
            var model = new CategoryShowViewModel
            {
                Products = productsToDisplay,
                Categories = categories
            };


            return View(model);

        }
    }
}