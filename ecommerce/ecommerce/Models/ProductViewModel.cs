﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ecommerce.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Feature = new List<FeatureViewModel>();
        }

        public ProductViewModel(ServiceReference.Product product)
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
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsOffer { get; set; }

        public double Percent { get; set; }

        public bool Enabled { get; set; }

        public DateTime StartDay { get; set; }

        public DateTime EndDay { get; set; }

        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public double Price { get; set; }

        public int CategoryId { get; set; }

        public List<FeatureViewModel> Feature { get; set; }

        public List<ServiceReference.Image> Images { get; set; }
        public string CategoryName { get; internal set; }
    }
}
