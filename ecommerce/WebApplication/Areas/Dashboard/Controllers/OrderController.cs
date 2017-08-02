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
    public class OrderController : Controller
    {

        private IService _service;
        public OrderController(IService service)
        {
            _service = service;
        }
        public ActionResult GetAll()
        {
            var banner = _service.GetAllOrders();

            var model = new List<OrderViewModel>();

            var orderStatus = _service.GetAllOrderStatus();
            foreach (var c in banner)
            {
                var cat = new OrderViewModel(c);
                cat.OrderStatusName = orderStatus.FirstOrDefault(x => x.Id == cat.OrderStateId).Name;
                model.Add(cat);
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var c = _service.GetOrderById(id);

            var model = new OrderViewModel(c);
            model.OrderStatus = _service.GetAllOrderStatus();            
            
            foreach(var prod in c.OrderProduct)
            {
                var p = new OrderProductViewModel
                {
                    NameProduct = prod.NameProduct,
                    Price = prod.Price,
                    Quantity = prod.Quantity
                };
                model.OrderProduct.Add(p);
            }
            return View(model);
        }


        [HttpPost]
        public ActionResult Edit(OrderViewModel order)
        {      
          

            _service.UpdateOrderStatus(order.Id, order.OrderStateId);

            return RedirectToAction("GetAll");
        }


    }
}