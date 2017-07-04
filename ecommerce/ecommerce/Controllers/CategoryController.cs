using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecommerce.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult GetById(int id)
        {
            return View();
        }

        public ActionResult GetAll()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(string example)
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string example)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete()
        {
            return View();
        }
    }
}