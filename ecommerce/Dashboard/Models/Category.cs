using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dashboard.Models
{
    public class Category
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public int Level { get; set; }
        
        public int ParentId { get; set; }
        
        public bool Enabled { get; set; }
    }
}