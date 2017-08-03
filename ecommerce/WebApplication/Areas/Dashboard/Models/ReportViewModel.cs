using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Areas.Dashboard.Models
{
    public class ReportViewModel
    {
        public Dictionary<string, double> SellsPerMonth { get; set; }
        public Dictionary<string, double> ProductBestCount { get; set; }
        public Dictionary<string, double> ProductBestSell { get; set; }
        public Dictionary<string, Dictionary<string, double>> TotalSells { get; set; }


    }
}