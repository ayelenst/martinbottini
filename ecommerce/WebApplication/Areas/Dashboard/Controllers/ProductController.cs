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
    public class ProductController : Controller
    {
        private IService _service;
        public ProductController(IService service)
        {
            _service = service;
        }

        public ActionResult GetAll()
        {
             
            var products = _service.GetAllProducts();

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
                    Warranty = c.Warranty,
                    Brant = c.Brant,
                    Stock = c.Stock,
                    TypeStock = c.TypeStock,

                };
                model.Add(prod);
            }
            return View(model);
        }

        public ActionResult GetById(int id)
        {
             
            var productClient = _service.GetProductById(id);

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
                Warranty = productClient.Warranty,
                Brant = productClient.Brant,
                TypeStock = productClient.TypeStock,
                Stock = productClient.Stock,
                
            };
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
             
            var productClient = _service.GetProductById(id);

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
                Warranty = productClient.Warranty,
                Brant = productClient.Brant,
                Images = productClient.Image,
                CategoryId = productClient.CategoryId,
                TypeStock = productClient.TypeStock,
                Stock = productClient.Stock,

            };
            model.Feature = _service.GetFeatureByProductId(model.Id).Select(x => new FeatureViewModel
            {
                Id = x.Id, Description = x.Description, Name = x.Name
            }).ToList();

            model.Images = _service.GetImageByProductId(id);
            if(model.Images == null)
            {
                model.Images = new List<Image>();
            }
            var completeModel = new ProductEditViewModel();
            completeModel.Product = model;
            var categoriesClient = _service.GetAllCategories();
            completeModel.Categories = categoriesClient.Select(x => new CategoryViewModel(x)).ToList();

            foreach (var c in completeModel.Categories)
            {
                c.Children = completeModel.Categories.Where(x => x.ParentId == c.Id).ToList();
            }

            var staticList = new List<KeyValuePair<int, string>>();
            staticList.Add(new KeyValuePair<int, string>(1, "Cantidad Fija"));
            staticList.Add(new KeyValuePair<int, string>(1, "Cantidad Ilimitada"));
            staticList.Add(new KeyValuePair<int, string>(1, "Disponible en 24 hs"));


            completeModel.Inventory = staticList;
            return View(completeModel);

        }

        [HttpPost]
        public JsonResult DeleteFile(int id)
        {           
            try
            {
                 
                var image = _service.GetImageById(id);
                //Delete file from the file system
                ImageHelper.DeleteImage(image.Url);
                _service.DeleteImage(id);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }


        [HttpPost]
        public ActionResult Edit(ProductViewModel product)
        {

             

            var model = new Product
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
                CategoryId = product.CategoryId,
                Warranty = product.Warranty,
                Brant = product.Brant,
                TypeStock = product.TypeStock,
                Stock = product.Stock,

            };

            SetDates(model);
           
            model.Feature = product.Feature.Where(x => x.Id >= 0 && x.Name != null).Select(x => new Feature
            {
                Description = x.Description,
                Name = x.Name,
                Id = x.Id,
                ProductID = model.Id
            }).ToList();

            model.Image = new List<Image>();

            for (int i = 0; i < Request.Files.Count; i++)
            {
                if (Request.Files[i].FileName == string.Empty)
                    continue;
                var file = Request.Files[i];
                var path = ImageHelper.SaveImage(product.Id.ToString(), file, Server.MapPath("~/Image"));
                bool isMain = false;
                if (Request.Files.AllKeys[i] == "file")
                {
                    isMain = true;
                }
                var imagetosave = new Image
                {
                    Url = path,
                    IsMain = isMain,
                    ProductId = product.Id
                };
                model.Image.Add(imagetosave);
            }
            

            _service.UpdateProduct(model);

            return RedirectToAction("GetAll");
        }


        [HttpGet]
        public ActionResult Add()
        {
             

            var model = new ProductViewModel();
            model.StartDay = DateTime.Now;
            model.EndDay = DateTime.Now;
            var completeModel = new ProductEditViewModel();
            completeModel.Product = model;
            var categoriesClient = _service.GetAllCategories();
            completeModel.Categories = categoriesClient.Select(x => new CategoryViewModel(x)).ToList();

            foreach (var c in completeModel.Categories)
            {
                c.Children = completeModel.Categories.Where(x => x.ParentId == c.Id).ToList();
            }
            var staticList = new List<KeyValuePair<int, string>>();
            staticList.Add(new KeyValuePair<int, string>(1, "Cantidad Fija"));
            staticList.Add(new KeyValuePair<int, string>(1, "Cantidad Ilimitada"));
            staticList.Add(new KeyValuePair<int, string>(1, "Disponible en 24 hs"));


            completeModel.Inventory = staticList;
            return View(completeModel);
        }


        [HttpPost]
        public ActionResult Add(ProductViewModel product)
        {
             

            var model = new Product
            {
                Id = 0,
                Name = product.Name,
                Description = product.Description,
                Enabled = true,
                IsOffer = product.IsOffer,
                Percent = product.Percent,
                Price = product.Price,
                StartDay = product.StartDay,
                EndDay = product.EndDay,
                CategoryId = product.CategoryId,
                Warranty = product.Warranty,
                Brant = product.Brant,
                TypeStock = product.TypeStock,
                Stock = product.Stock,
            };
            SetDates(model);

            model.Feature = product.Feature.Where(x => x.Id >= 0 && x.Name != null).Select(x => new Feature
            {
                Description = x.Description,
                Name = x.Name,
                Id = x.Id,
                ProductID = model.Id
            }).ToList();
            model.Image = new List<Image>();

            var id = _service.AddProduct(model);


            for (int i = 0; i < Request.Files.Count; i++)
            {
                var file = Request.Files[i];
                if (file.FileName == string.Empty)
                    continue;
                var path = ImageHelper.SaveImage(id.ToString(), file, Server.MapPath("~/Image"));


                bool isMain = false;
                if (Request.Files.AllKeys[i] == "file")
                {
                    isMain = true;
                }
                var imagetosave = new Image
                {
                    Url = path,
                    IsMain = isMain,
                    ProductId = id
                };
                model.Image.Add(imagetosave);
            }
            _service.AddImageRange(model.Image);


            return RedirectToAction("GetAll");

        }

        private void SetDates(Product model)
        {
            model.StartDay = ConvertDate(this.HttpContext.Request.Form["Product.StartDay"]);
            model.EndDay = ConvertDate(this.HttpContext.Request.Form["Product.EndDay"]);
            
        }

        private DateTime ConvertDate(string date)
        {   
               var splited = date.Split('/');
            var day = Int32.Parse(splited[1]);
            var month = Int32.Parse(splited[0]);
            var year = Int32.Parse(splited[2]);
            return new DateTime(year, month, day);
        }

        public ActionResult Delete(int id)
        {
            var path = Path.Combine(Server.MapPath("~/Image"), id.ToString());
            if (Directory.Exists(path))
            {
                System.IO.DirectoryInfo di = new DirectoryInfo(path);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                di.Delete(true);
            }
            
             
            _service.DeleteProduct(id);
            return RedirectToAction("GetAll");
        }

    }
}