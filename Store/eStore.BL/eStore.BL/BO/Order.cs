using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStore.BL.BO
{
    public class Order
    {
        public int ID { get; set; }
        public string OrderNumber { get; set; }
        public User User { get; set; }
    }
}
