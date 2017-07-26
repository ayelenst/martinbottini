using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Areas.Ecommerce.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Doomy { get; set; }
        public int Level { get; internal set; }
        public int? Parent { get; internal set; }

        public bool IsEnable{ get; internal set; }

        public int CountChildren { get; set; }

        public int CountProduct { get; set; }


    }
}