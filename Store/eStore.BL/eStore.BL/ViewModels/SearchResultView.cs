using eStore.BL.BO;
using System.Collections.Generic;

namespace eStore.BL.ViewModels
{
    public class SearchResultView
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
