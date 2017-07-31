using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Areas.Ecommerce.Models;

namespace WebApplication.Areas.Ecommerce.Controllers
{
    public class ShoppingCartController : BaseController
    {
        private IService _service;
        public ShoppingCartController(IService service):base(service)
        {
            _service = service;
        }

        public ActionResult AddProduct (int id, string name, double price, int count)
        {
            var smallproduct = new SmallProduct
            {
                Id = id,
                Name = name,
                Count = count,
                Price = price
            };
            SessionHelper.Add(smallproduct, Session);
            return Json(new { url= Url.Action("Index", "Home") });
        }

        public ActionResult RemoveProduct(int id)
        {
           
            SessionHelper.Remove(id, Session);

            return Json(new { url = Url.Action("Index", "Home") });
        }
    }
}