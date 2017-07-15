using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dashboard.Models;


namespace Dashboard.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult GetAll()
        {
            var app = new ServiceReference.ContractClient();
            var products = app.GetAllProducts();

            var model = new List<ProductViewModel>();
            foreach (var c in products)
            {
                var prod = new ProductViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Enabled = c.Enabled,
                    IsOffer = c.IsOffer,
                    Percent = c.Percent,
                    Price = c.Price,
                    StartDay = c.StartDay,
                    EndDay = c.EndDay,
                    // Category = c.Category,

                };
                model.Add(prod);
            }
            return View(model);
        }

        public ActionResult GetById(int id)
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
                // Category = c.Category,
            };
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
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
                // Category = c.Category,

            };
            return View(model);
        }



        [HttpPost]
        public ActionResult Edit(ProductViewModel product)
        {
            var app = new ServiceReference.ContractClient();

            var model = new ServiceReference.Product
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Enabled = product.Enabled,
                IsOffer = product.IsOffer,
                Percent = product.Percent,
                Price = product.Price,
                StartDay = product.StartDay,
                EndDay = product.EndDay,
                // Category = c.Category,
            };

            app.UpdateProduct(model);

            return RedirectToAction("GetById", new { id = product.Id });
        }


        [HttpGet]
        public ActionResult Add()
        {
            var app = new ServiceReference.ContractClient();

            var model = new ProductViewModel();
            return View(model);
        }


        [HttpPost]
        public ActionResult Add(ProductViewModel product)
        {
            var app = new ServiceReference.ContractClient();

            var model = new ServiceReference.Product
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Enabled = product.Enabled,
                IsOffer = product.IsOffer,
                Percent = product.Percent,
                Price = product.Price,
                StartDay = product.StartDay,
                EndDay = product.EndDay,
                // Category = c.Category,
            };
            app.AddProduct(model);

            return RedirectToAction("GetAll");

        }


        public ActionResult Delete(int id)
        {
            var app = new ServiceReference.ContractClient();
            app.DeleteProduct(id);
            return RedirectToAction("GetAll");
        }

    }
}