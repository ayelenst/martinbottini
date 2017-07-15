using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dashboard.Models
{
    public class CategoryViewModel
    {
        public CategoryViewModel() { }

        public CategoryViewModel(ServiceReference.Category categoryClient)
        {
            Id = categoryClient.Id;
            Name = categoryClient.Name;
            Description = categoryClient.Description;
            Level = categoryClient.Level;
            ParentId = categoryClient.ParentId;
            Enabled = categoryClient.Enabled;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public int ParentId { get; set; }

        public bool Enabled { get; set; }
    }
}