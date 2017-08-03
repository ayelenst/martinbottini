using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Areas.Dashboard.Models
{
    public class OrderViewModel
    {
        public OrderViewModel() { }
        public OrderViewModel(Order c)
        {
            this.Id = c.Id;
            NameCustomer = c.NameCustomer;
            OrderProduct = new List<OrderProductViewModel>();
            OrderStateId = c.OrderStatusId;
            Mail = c.Mail;
            Phone = c.Phone;
            OrderDate = c.OrderDate;
            OrderDone = c.OrderDone;
            Total = c.Total;
            Payment = c.Payment;

        }

        public int Id { get; set; }
        
        public string NameCustomer { get; set; }

        
        public virtual List<OrderProductViewModel> OrderProduct { get; set; }
        
        public int OrderStateId { get; set; }
        
        public List<OrderStatus> OrderStatus { get; set; }
        
        public string Mail { get; set; }
        
        public string Phone { get; set; }
        
        public string Payment { get; set; }
        
        public DateTime OrderDate { get; set; }
        
        public DateTime OrderDone { get; set; }

        public string OrderStatusName { get;set; }

        public double Total { get; set; }
    }
}