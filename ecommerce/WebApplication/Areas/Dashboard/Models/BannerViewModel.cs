using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Areas.Dashboard.Models
{
    public class BannerViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "La imagen es obligatoria")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Titulo es obligatorio")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Descripcion es obligatorio")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Url es obligatorio")]
        public string Url { get; set; }

    }
}