using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B4P.Models;

namespace B4P.ViewModels
{
    public class PersonalOrders
    {
        public List<int> OrderGoods { get; set; }
        public List<string> goodsPhoto { get; set; }
        public IEnumerable<Orders> Order { get; set; }
    }
}
