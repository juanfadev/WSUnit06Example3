using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;

namespace WSUnit06.Example3.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            //ApplicationServicesSoapClient application = new ApplicationServicesSoapClient();
            return View(application.getProducts());
        }

        public ActionResult Product(String name)
        {
            string ip = GetIPAddress();
        }
    }
}