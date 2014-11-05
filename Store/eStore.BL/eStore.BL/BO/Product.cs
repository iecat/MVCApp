using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStore.BL.BO
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public DateTime AddedDate { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public Price Price { get; set; }
        public ICollection<ProductImages> ProductImages { get; set; }
    }
}
