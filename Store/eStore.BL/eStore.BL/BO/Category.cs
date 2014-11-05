using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStore.BL.BO
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Category ParentCategory { get; set; }
        //public ICollection<Product> Products { get; set; }
    }
}
