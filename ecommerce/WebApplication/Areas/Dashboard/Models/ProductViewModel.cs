using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Areas.Dashboard.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Feature = new List<FeatureViewModel>();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Descripción es obligatorio")]
        public string Description { get; set; }

        public string Brant { get; set; }

        public string Warranty { get; set; }

        public bool IsOffer { get; set; }

        [Required(ErrorMessage = "Porcentaje es obligatorio")]
        public double Percent { get; set; }

        public bool Enabled { get; set; }

        [Required(ErrorMessage = "Fecha de inicio es obligatorio")]
        [DataType(DataType.Date)]
       
        public DateTime StartDay { get; set; }

        [Required(ErrorMessage = "Fecha fin es obligatorio")]
        [DataType(DataType.Date)]
    
        public DateTime EndDay { get; set; }

        [Required(ErrorMessage = "Precio es obligatorio")]
        [DisplayFormat(DataFormatString = "{#0.00#}", ApplyFormatInEditMode = true)]
        public double Price { get; set; }

        [Required(ErrorMessage = "Categoria es obligatorio")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Tipo es obligatorio")]
        public int? TypeStock { get; set; }

        public int? Stock { get; set; }

        public List<FeatureViewModel> Feature { get; set; }

        public List<Image> Images { get; set; }

        
    }
}
