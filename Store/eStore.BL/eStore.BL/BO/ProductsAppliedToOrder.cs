using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStore.BL.BO
{
    public class ProductsAppliedToOrder
    {
        public int ID { get; set; }
        public Order Order { get; set; }
    }
}
