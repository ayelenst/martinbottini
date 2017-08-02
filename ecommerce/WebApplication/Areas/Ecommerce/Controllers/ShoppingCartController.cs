﻿using Model;
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

        public ActionResult AddProduct (int id, string name, double price, int count, string url)
        {
            var smallproduct = new SmallProduct
            {
                Id = id,
                Name = name,
                Count = count,
                Price = price, 
                Url = url
            };
            SessionHelper.Add(smallproduct, Session);
            return Json(new { url= Url.Action("Index", "Home") });
        }

        public ActionResult RemoveProduct(int id)
        {
           
            SessionHelper.Remove(id, Session);

            return Json(new { url = Url.Action("Index", "Home") });
        }

        public ActionResult ChangeCount(int id, int newCount)
        {

            SessionHelper.UpdateCount(id, newCount, Session);

            return Json("");
        }


        public ActionResult ViewCart()
        {
            if (HttpContext.Session["cart"] != null)
            {
                return View((ShoppingCartViewModel)HttpContext.Session["cart"]);
            }
            return View(new ShoppingCartViewModel());
        }

        public void Update(ShoppingCartViewModel result)
        {
            var r = result;
            return;
           
        }

        public ActionResult Checkout()
        {
            var model = new OrderModel();
            model.Products = new List<SmallProduct>();
            if (HttpContext.Session["cart"] != null)
            {

                //todo check stock?
               
                var cart = (ShoppingCartViewModel)HttpContext.Session["cart"];
                model.Products = cart.Products;
                model.Total = cart.Total;
                return View(model);
            }
            return View(model);

        }

        public ActionResult PlaceOrder(OrderModel model)
        {
            var order = new Order
            {
                Mail = model.Mail,
                OrderDate = DateTime.Now,
                NameCustomer = model.NameCustomer,
                OrderDone = DateTime.Now,
                Phone = model.Phone,
                Payment = "",
                OrderStatusId = 1,
                Total = model.Total
            };
            var cart = (ShoppingCartViewModel)HttpContext.Session["cart"];
            if(cart != null)
            {
                model.Products = cart.Products;
                var products = new List<OrderProduct>();
                foreach (var prod in cart.Products)
                {
                    var p = new OrderProduct
                    {
                        NameProduct = prod.Name,
                        Price = prod.Price,
                        Quantity = prod.Count
                    };
                    products.Add(p);
                }

                _service.PlaceOrder(order, products);
            }
         

            return RedirectToAction("OrderFinish");
        }

        public ActionResult OrderFinish()
        {
            var model = new OrderModel();
            model.Products = new List<SmallProduct>();
            if (HttpContext.Session["cart"] != null)
            {

                //todo check stock?

                var cart = (ShoppingCartViewModel)HttpContext.Session["cart"];
                model.Products = cart.Products;
                model.Total = cart.Total;
                return View(model);
            }
            return View(model);
        }
    }
}