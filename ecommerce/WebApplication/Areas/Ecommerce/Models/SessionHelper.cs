using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Areas.Ecommerce.Models
{
    public static class  SessionHelper
    {
        public static void Add(SmallProduct product, HttpSessionStateBase session)
        {
            if (HttpContext.Current.Session["cart"] == null)
            {
                var cart = new ShoppingCartViewModel();
                cart.Count = 0;
                cart.Total = 0;
                cart.Products = new List<SmallProduct>();
                HttpContext.Current.Session["cart"] = cart;
            }
            var current = (ShoppingCartViewModel)HttpContext.Current.Session["cart"];
            current.Count = current.Count + product.Count;
            current.Total = current.Total + product.Price * product.Count;
            if (current.Products.Any(x => x.Id == product.Id))
            {
                var currentproduct = current.Products.FirstOrDefault(x => x.Id == product.Id);
                currentproduct.Count = currentproduct.Count + product.Count;
            }
            else
            {
                current.Products.Add(product);
            }
            HttpContext.Current.Session["cart"] = current;
            return;
        }

        public static void Remove(int id, HttpSessionStateBase session)
        {
            if (HttpContext.Current.Session["cart"] == null)
            {
                var cart = new ShoppingCartViewModel();
                cart.Count = 0;
                cart.Total = 0;
                cart.Products = new List<SmallProduct>();
                HttpContext.Current.Session["cart"] = cart;
                return ;
            }
            var current = (ShoppingCartViewModel)HttpContext.Current.Session["cart"];
           if(current.Products.Any(x=>x.Id == id))
            {
                var currentProduct = current.Products.FirstOrDefault(x => x.Id == id);
                current.Count = current.Count + currentProduct.Count;
                current.Total = current.Total + currentProduct.Price * currentProduct.Count;
                current.Products.Remove(currentProduct);
                HttpContext.Current.Session["cart"] = current;
            }
        }
    }
}