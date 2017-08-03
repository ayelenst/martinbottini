using WebApplication.Areas.Ecommerce.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Areas.Ecommerce.Controllers
{
    public class CategoryController : BaseController
    {
        private IService _service;
        public CategoryController(IService service):base(service)
        {
            _service = service;
        }

        public ActionResult GetById(int id = 0, bool isOffer = false)
        {
            var categories = ViewBag.LayoutModel as List<CategoryViewModel>;
            List<ProductViewModel> productsToDisplay;
            if (id == 0)
            {
                if (isOffer)
                {
                    productsToDisplay = _service.GetProductLastOffers(null).Select(x => new ProductViewModel(x)).ToList();
                }
                else
                {
                    productsToDisplay = _service.GetAllProducts().Select(x => new ProductViewModel(x)).ToList();
                }
            }
            else
            {

                productsToDisplay = _service.GetProductByCategory(id, isOffer).Select(x => new ProductViewModel(x)).ToList();
            }


            var categoriesAmount = _service.GetCategoryCount(isOffer);
            foreach (var c in categories)
            {
                c.CountProduct = categoriesAmount.FirstOrDefault(x => x.Key == c.Id).Value;
            }

            
            foreach (var c in productsToDisplay)
            {
                c.Images = _service.GetImageByProductId(c.Id);
                foreach(var i in c.Images)
                {
                    i.Products = null;
                }
            }
            var model = new CategoryShowViewModel
            {
                Products = productsToDisplay,
                Categories = categories
            };

            if(id != 0)
            {
                model.CurrentCategory = categories.FirstOrDefault(x => x.Id == id);
            }


            return View(model);

        }
    }
}