using System;
using System.Collections.Generic;

namespace B4P.Models
{
    public partial class Comment
    {
        public Comment()
        {
            Orders = new HashSet<Orders>();
        }

        public decimal CommentId { get; set; }
        public decimal GoodsId { get; set; }
        public decimal UserId { get; set; }
        public string Comment1 { get; set; }

        public virtual Good Goods { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
