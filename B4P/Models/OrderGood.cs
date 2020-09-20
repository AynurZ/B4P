using System;
using System.Collections.Generic;

namespace B4P.Models
{
    public partial class OrderGood
    {
        public int OrderGood1 { get; set; }
        public int OrderId { get; set; }
        public decimal GoodsId { get; set; }

        public virtual Good Goods { get; set; }
        public virtual Orders Order { get; set; }
    }
}
