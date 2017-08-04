using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Areas.Ecommerce.Models
{
    public class CategoryShowViewModel
    {
        public List<ProductViewModel> Products { get; set; }

        public List<CategoryViewModel> Categories { get; set; }

        public CategoryViewModel CurrentCategory { get; set; }
        public bool RequireOffer { get; set; }
    }
}