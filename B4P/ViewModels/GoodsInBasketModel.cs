using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B4P.Models;

namespace B4P.ViewModels
{
    public class GoodsInBasketModel
    {
        public List<int> Amount { get; set; }
        public IEnumerable<Good> Goods { get; set; }
    }
}
