using eStore.BL.BO;
using eStore.DBO;
using eStore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace eStore.Controllers
{
    public class HomeController : Controller
    {
        private eStoreDBContext db = new eStoreDBContext();
        ProductsManager prodDBO = new ProductsManager();

        public ActionResult Index()
        {
            HomeView hv = new HomeView();
            hv.FeaturedProducts = prodDBO.GetFeaturedProducts();
            hv.SalesProducts = prodDBO.GetSalesProducts();
            hv.Categories = prodDBO.GetAllCategories();
            hv.Brands = prodDBO.GetBrands(null);

            ViewBag.Search_Cat = new SelectList(hv.Categories.Select(c => c.Name));

            return View(hv);
        }

        public ActionResult Search(string Search_Cat)
        {
            SearchResultView sv = new SearchResultView();
            sv.Products = prodDBO.SearchProducts(Search_Cat);
            if (sv.Products != null)
            {
                return View(sv);
            }
            else
            {
                return HttpNotFound();
            }
        }

      
        public void Add(int idP)
        {
            List<int> products;// = new List<Product>();
            if (Session["AddedProducts"] != null)
            {
                products = new List<int>();
                products.AddRange((List<int>)Session["AddedProducts"]);
            }
            else
            {
                products = new List<int>();
                products.Add(idP);
                Session["AddedProducts"] = products;
            }

        }

    }
}