using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStore.BL.BO
{
    public class ProductImages
    {
        public int ID { get; set; }
        public Product Product { get; set; }
        public string ImageUrl { get; set; }
    }
}
