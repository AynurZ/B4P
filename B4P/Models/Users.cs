using System;
using System.Collections.Generic;

namespace B4P.Models
{
    public partial class Users
    {
        public Users()
        {
            Basket = new HashSet<Basket>();
            Comment = new HashSet<Comment>();
            Orders = new HashSet<Orders>();
        }

        public decimal UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public string UserFamily { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public DateTime? UserBirthday { get; set; }
        public string UserAdress { get; set; }
        public string UserIp { get; set; }
        public string UserMail { get; set; }
        public string UserPhone { get; set; }
        public decimal? UserDiscount { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Basket> Basket { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
