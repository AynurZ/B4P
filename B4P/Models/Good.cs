using System;
using System.Collections.Generic;

namespace B4P.Models
{
    public partial class Good
    {
        public Good()
        {
            Basket = new HashSet<Basket>();
            Comment = new HashSet<Comment>();
            OrderGood = new HashSet<OrderGood>();
        }

        public decimal GoodsId { get; set; }
        public decimal CategoryId { get; set; }
        public int SizeId { get; set; }
        public string GoodName { get; set; }
        public string GoodDescription { get; set; }
        public decimal GoodPrice { get; set; }
        public string GoodPhotoUrl { get; set; }
        public decimal GoodAmount { get; set; }
        public decimal? GoodDiscount { get; set; }

        public virtual Size Size { get; set; }
        public virtual ICollection<Basket> Basket { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<OrderGood> OrderGood { get; set; }
    }
}
