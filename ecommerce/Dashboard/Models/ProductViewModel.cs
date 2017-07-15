using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dashboard.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsOffer { get; set; }

        public double Percent { get; set; }

        public bool Enabled { get; set; }

        public DateTime StartDay { get; set; }

        public DateTime EndDay { get; set; }

        public double Price { get; set; }

        public int CategoryId { get; set; }

    }
}
