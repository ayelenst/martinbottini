
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Areas.Dashboard.Models;

namespace WebApplication.Areas.Dashboard.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IService _service;
        public HomeController(IService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            Dictionary<string, double> sellsPerMonth;
            Dictionary<string, double> productBestCount;
            Dictionary<string, double> productBestSell;
            Dictionary<string, Dictionary<string, double>> totalSells;

        _service.GetReports(out sellsPerMonth, out productBestCount, out productBestSell, out totalSells);
            var model = new ReportViewModel();
            model.SellsPerMonth = sellsPerMonth;
            model.ProductBestCount = productBestCount;
            model.ProductBestSell = productBestSell;
            model.TotalSells = totalSells;

            return View(model);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}