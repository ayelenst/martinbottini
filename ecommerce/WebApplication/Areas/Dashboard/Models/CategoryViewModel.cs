using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Areas.Dashboard.Models
{
    public class CategoryViewModel
    {
        public CategoryViewModel() { }

        public CategoryViewModel(Category categoryClient)
        {
            Id = categoryClient.Id;
            Name = categoryClient.Name;
            Description = categoryClient.Description;
            Level = categoryClient.Level;
            ParentId = categoryClient.ParentId;
            Enabled = categoryClient.Enabled;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Descripción es obligatorio")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Nivel es obligatorio")]
        public int Level { get; set; }

        public int? ParentId { get; set; }

        public bool Enabled { get; set; }

        public bool HasProducts { get; set; }

        public bool HasChildren { get; set; }

        public List<CategoryViewModel> Children { get; set; }
        public List<CategoryViewModel> ParentCategories { get; internal set; }
    }
}