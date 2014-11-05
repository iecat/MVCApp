using eStore.BL.BO;
using System.Collections.Generic;

namespace eStore.Models
{
    public class SearchResultView
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
