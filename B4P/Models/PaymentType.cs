using System;
using System.Collections.Generic;

namespace B4P.Models
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            Orders = new HashSet<Orders>();
        }

        public int PaymentTypeId { get; set; }
        public string PaymentType1 { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
