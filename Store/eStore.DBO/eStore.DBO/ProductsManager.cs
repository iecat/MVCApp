using eStore.BL.BO;
using System.Collections.Generic;
using System.Linq;

namespace eStore.DBO
{
    public class ProductsManager
    {
        eStoreDBContext db = new eStoreDBContext();
        public IEnumerable<Product> GetFeaturedProducts()
        {

            IEnumerable<Product> result;
            List<Product> tempList = new List<Product>();
            tempList = db.Product.Take(5).ToList();
            List<Price> prices = db.Price.ToList();

           
            result = tempList;
            return result;
        }
        public IEnumerable<Product> GetSalesProducts()
        {
            IEnumerable<Product> result = from p in db.Product
                                          where p.Price.DiscountPercentage > 0
                                          select p;
            return result.Take(5);
        }
        public IEnumerable<Category> GetAllCategories()
        {
            IEnumerable<Category> result = from c in db.Category
                                           select c;
            return result;
        }
        public IEnumerable<Brand> GetBrands(int? categoryId)
        {
            IEnumerable<Brand> brands;
            if (categoryId.HasValue)
            {
                brands = from p in db.Product
                         where p.Category.ID.Equals(categoryId)
                         select p.Brand;
            }
            else
            {
                brands = from p in db.Product
                         select p.Brand;
            }

            return brands;
        }
        public IEnumerable<Product> SearchProducts(string catName)
        {
            List<Price> prices = db.Price.ToList();
            IEnumerable<Product> result = from p in db.Product
                                          where p.Category.Name.Equals(catName)
                                          select p;
            return result;
        }
        public Product GetProductByID(int id)
        {
            List<Price> prices = db.Price.ToList();
            List<ProductImages> prodImages = db.ProductImages.ToList();

            return db.Product.Find(id);
        }

        public void AddProductToCart(Product product)
        {
           

        }
    }
}
