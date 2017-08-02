using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Areas.Dashboard.Models
{
    public class OrderProductViewModel
    {
        public int OrderProductId { get; set; }
        
        public string NameProduct { get; set; }
        public int Quantity { get; set; }
        
        public double Price { get; set; }
        
        public int OrderId { get; set; }
    }
}