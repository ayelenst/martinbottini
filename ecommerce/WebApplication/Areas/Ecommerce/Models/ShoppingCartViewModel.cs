using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Areas.Ecommerce.Models
{
    public class ShoppingCartViewModel
    {
        public double Total { get; set; }
        public List<SmallProduct> Products { get; set; }
        public int Count { get; set; }
    }
}