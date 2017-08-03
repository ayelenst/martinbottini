using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Areas.Ecommerce.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Feature = new List<FeatureViewModel>();
        }

        public ProductViewModel(Product product)
        {
            Feature = new List<FeatureViewModel>();
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
            Enabled = product.Enabled;
            IsOffer = product.IsOffer;
            Percent = product.Percent;
            Price = product.Price;
            StartDay = product.StartDay;
            EndDay = product.EndDay;
            Brand = product.Brant;
            CategoryId = product.CategoryId;
            Warranty = product.Warranty;
            Quantity = 1;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsOffer { get; set; }

        public double Percent { get; set; }

        public bool Enabled { get; set; }

        public DateTime StartDay { get; set; }

        public DateTime EndDay { get; set; }

        public double OfferPrice { get
            {
                return (Price - Price * Percent / 100);
            }
        }

        public string MainUrl
        {
            get
            {
                if(Images.Any(x => x.IsMain))
                return "/Image/"+Images.FirstOrDefault(x => x.IsMain).Url;
                return "";
            }
        }

        public bool IsSale
        {
            get
            {
                return IsOffer && StartDay < DateTime.Now && EndDay > DateTime.Now;
            }
        }

        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public double Price { get; set; }

        public int CategoryId { get; set; }

        public List<FeatureViewModel> Feature { get; set; }

        public List<Image> Images { get; set; }
        public string CategoryName { get; internal set; }
        public string Brand { get; private set; }
        public string Warranty { get; private set; }

        public int Quantity { get; set; }
    }
}
