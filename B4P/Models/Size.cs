using System;
using System.Collections.Generic;

namespace B4P.Models
{
    public partial class Size
    {
        public Size()
        {
            Basket = new HashSet<Basket>();
            Good = new HashSet<Good>();
        }

        public int SizeId { get; set; }
        public string Size1 { get; set; }

        public virtual ICollection<Basket> Basket { get; set; }
        public virtual ICollection<Good> Good { get; set; }
    }
}
