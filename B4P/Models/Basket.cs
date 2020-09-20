using System;
using System.Collections.Generic;

namespace B4P.Models
{
    public partial class Basket
    {
        public int Id { get; set; }
        public decimal? UserId { get; set; }
        public decimal? GoodsId { get; set; }
        public int? SizeId { get; set; }
        public int Amount { get; set; }

        public virtual Good Goods { get; set; }
        public virtual Size Size { get; set; }
        public virtual Users User { get; set; }
    }
}
