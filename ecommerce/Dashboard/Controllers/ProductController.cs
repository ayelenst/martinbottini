using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dashboard.Models;
using System.IO;

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
            };
            var completeModel = new ProductEditViewModel();
            completeModel.Product = model;
            var categoriesClient = app.GetAllCategories();
            completeModel.Categories = categoriesClient.Select(x => new CategoryViewModel(x)).ToList();

            foreach (var c in completeModel.Categories)
            {
                c.Children = completeModel.Categories.Where(x => x.ParentId == c.Id).ToList();
            }

            return View(completeModel);
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
            var completeModel = new ProductEditViewModel();
            completeModel.Product = model;
            var categoriesClient = app.GetAllCategories();
            completeModel.Categories = categoriesClient.Select(x => new CategoryViewModel(x)).ToList();

            foreach (var c in completeModel.Categories)
            {
                c.Children = completeModel.Categories.Where(x => x.ParentId == c.Id).ToList();
            }



            return View(completeModel);
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
                CategoryId = product.CategoryId
            };
            model.Feature = product.Feature.Where(x => x.Id >= 0 && x.Name != null).Select(x => new ServiceReference.Feature {
                Description=x.Description,Name = x.Name, Id = x.Id, ProductID = model.Id
            }).ToList();
            model.Image = new List<ServiceReference.Image>();
            var allowedExtensions = new[] {
            ".Jpg", ".png", ".jpg", "jpeg"
        };
            for (int i = 0; i < Request.Files.Count; i++)
            {
                var file = Request.Files[i];
                var fileName = Path.GetFileName(file.FileName); //getting only file name(ex-ganesh.jpg)  
                var ext = Path.GetExtension(file.FileName); //getting the extension(ex-.jpg)  
                if (allowedExtensions.Contains(ext)) //check what type of extension  
                {
                    string name = Path.GetFileNameWithoutExtension(fileName); //getting file name without extension      
                    string myfile = Guid.NewGuid().ToString()+ext;
                    var path = Path.Combine(Server.MapPath("~/Image"), myfile);
                    bool isMain = false;
                    if (Request.Files.AllKeys[i]=="file")
                    {
                        isMain = true;
                    }
                    var imagetosave = new ServiceReference.Image
                    {
                        Url = path,
                        IsMain = isMain
                    };
                    model.Image.Add(imagetosave);
                    file.SaveAs(path);
                }                
            }

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