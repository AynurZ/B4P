using System;
using System.Collections.Generic;

namespace B4P.Models
{
    public partial class Delivery
    {
        public Delivery()
        {
            Orders = new HashSet<Orders>();
        }

        public int DeliveryId { get; set; }
        public string DeliveryName { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
