using eStore.BL.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eStore.Controllers
{
    public class CheckoutController : Controller
    {
        //
        // GET: /Checkout/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Add(Product product)
        {
            List<Product> products;// = new List<Product>();
            if(Session["AddedProducts"] !=null)
            {
                products = new List<Product>();
                products.AddRange((List<Product>)Session["AddedProducts"]);
            }
            else
            {
                products = new List<Product>();
                products.Add(product);
                Session["AddedProducts"] = products;
            }

        }
	}
}