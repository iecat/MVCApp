using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStore.BL.BO
{
    public class Price
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal PriceValue { get; set; }
        public int VATPercentage { get; set; }
        public int DiscountPercentage { get; set; }
        public string Currency { get; set; }
        //public ICollection<Product> Products { get; set; }

    }
}
