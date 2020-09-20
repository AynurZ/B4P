using System;
using System.Collections.Generic;

namespace B4P.Models
{
    public partial class Status
    {
        public Status()
        {
            Orders = new HashSet<Orders>();
        }

        public int StatusId { get; set; }
        public string Status1 { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
