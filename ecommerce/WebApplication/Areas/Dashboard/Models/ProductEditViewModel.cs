using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Areas.Dashboard.Models
{
    public class ProductEditViewModel
    {
        public ProductViewModel Product {get;set;}
        public List<CategoryViewModel> Categories { get; set; }
        public List<KeyValuePair<int, string>> Inventory { get; internal set; }
    }
}