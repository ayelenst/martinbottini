using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Areas.Ecommerce.Models
{
    public class OrderModel
    {
        public string NameCustomer { get; set; }        
        
        public string Mail { get; set; }

        public string Phone { get; set; }
        
        public List<SmallProduct> Products { get; set; }

        public double Total { get; set; }
    }
}