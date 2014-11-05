using eStore.BL.BO;
using eStore.DBO;
using eStore.Models;
using System.Net;
using System.Web.Mvc;

namespace eStore.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Details/
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ProductsManager dbo = new ProductsManager();
            ProductDetailsView pv = new ProductDetailsView();
            pv.Product = dbo.GetProductByID(id.Value);
            if (pv.Product != null)
            {
                return View(pv);
            }
            else
            { return HttpNotFound(); }
        }
    }
}