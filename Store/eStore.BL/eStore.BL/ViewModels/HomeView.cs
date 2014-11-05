using eStore.BL.BO;
using System.Collections.Generic;

namespace eStore.BL.ViewModels
{
    public class HomeView
    {
        public IEnumerable<Product> FeaturedProducts { get; set; }
        public IEnumerable<Product> SalesProducts { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
    }
}
