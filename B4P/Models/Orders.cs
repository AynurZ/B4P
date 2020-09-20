using System;
using System.Collections.Generic;

namespace B4P.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderGood = new HashSet<OrderGood>();
        }

        public int OrderId { get; set; }
        public decimal UserId { get; set; }
        public int DeliveryId { get; set; }
        public decimal CommentId { get; set; }
        public int PaymentTypeId { get; set; }
        public int StatusId { get; set; }
        public decimal OrderSum { get; set; }
        public decimal OrderSumAll { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? OrderDateDelivery { get; set; }
        public string OrderOperation_Id { get; set; }
        public virtual Comment Comment { get; set; }
        public virtual Delivery Delivery { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual Status Status { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<OrderGood> OrderGood { get; set; }
    }
}
