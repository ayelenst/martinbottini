using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecommerce.Models
{
    public class HomeViewModel
    {
        
        public List<ProductViewModel> LastAddedProduct { get; set; }
        public List<ProductViewModel> OfferProduct { get; set; }
        public List<BannerViewModel> BannerViewModels { get; set; }

        public HomeViewModel()
        {
            LastAddedProduct = new List<ProductViewModel>();
            OfferProduct = new List<ProductViewModel>();
            BannerViewModels = new List<BannerViewModel>();
        }
    }
}