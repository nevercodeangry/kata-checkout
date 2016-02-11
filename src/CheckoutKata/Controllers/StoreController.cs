using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheckoutKata.ViewModels;
using CheckoutKata.Services;

namespace CheckoutKata.Controllers
{
    public class StoreController : Controller
    {
        private ProductService _service;
        public StoreController()
        {
            _service = new ProductService();
        }
        // GET: Checkout
        public ActionResult Index()
        {
            ViewBag.Total = 0;
            return View(new ProductViewModel());
        }
        [HttpPost]
        public ActionResult Index(ProductViewModel model)
        {
            //get total
            ViewBag.Total = _service.Checkout(model.Item);
            return View(model);
        }
    }
}