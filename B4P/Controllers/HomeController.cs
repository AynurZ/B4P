using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using B4P.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using B4P.ViewModels;
using System.Security.Cryptography;
using System.Text;

namespace B4P.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private B4PTestContext _context;
        
        public HomeController(ILogger<HomeController> logger, B4PTestContext context)
        {
            _logger = logger;
            _context = context;
            ViewData["Enter"] = "Войти";
        }


        //[Authorize(Roles = "admin")]
        //[AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Action()
        {
            var actiongoods = await _context.Good.Where(c => c.GoodDiscount != null).ToListAsync();
            return View(actiongoods);
        }
        [Authorize]
        public async Task<IActionResult> Goods()
        {
            var goods = await _context.Good.ToListAsync();
            return View(goods); ;
        }
        //[Authorize(Policy = "OnlyForAdmins")]
        public IActionResult PaymentType()
        {
            return View();
        }
        public async Task<IActionResult> Basket()
        {
            //var goodsInBasket = _context.Basket.Where(p => p.UserId == int.Parse(User.Identity.Name)).ToList();
            IEnumerable<Good> goods = from good in _context.Good join baskets in _context.Basket on good.GoodsId equals baskets.GoodsId where baskets.UserId == int.Parse(User.Identity.Name) select good;
            List<int> amount = await _context.Basket.Where(p => p.UserId == int.Parse(User.Identity.Name)).Select(p => p.Amount).ToListAsync();
            var model = new GoodsInBasketModel
            {
                Goods = goods,
                Amount = amount

            };
            return View(model);
            //IEnumerable<Basket> goodsInBasket = await _context.Basket.Where(p=>p.UserId==int.Parse(User.Identity.Name)).ToListAsync();
            //return View(goodsInBasket);
            //return View();

        }
        public IActionResult Delivery()
        {
            return View();
        }

        public async Task AddGood(int goodId)
        {
            Basket goodInBasket = await _context.Basket.FirstOrDefaultAsync(u => u.GoodsId == goodId);
            if (goodInBasket == null)
            {
                // добавляем пользователя в бд
                goodInBasket = new Basket { UserId = int.Parse(User.Identity.Name), GoodsId = goodId, SizeId = 1, Amount = 1 };
                _context.Basket.Add(goodInBasket);
                await _context.SaveChangesAsync();
            }
            else
            {
                goodInBasket.Amount++;
                _context.Basket.Update(goodInBasket);
                await _context.SaveChangesAsync();
            }

        }
        [HttpPost]
        public async Task<IActionResult> Pay(int goodId)
        {
            Orders order = await _context.Orders.FirstOrDefaultAsync(u => u.UserId == int.Parse(User.Identity.Name));
            if (order != null)
            {
                OrderModel orderModel = new OrderModel { OrderId = order.OrderId, Sum = order.OrderSum };
                return View(orderModel);
            }

            return NotFound();
        }
        [HttpGet]
        public string Paid()
        {
            return "<p>оплачено</p>";
        }

        [HttpPost]
        public void Paid(string notification_type, string operation_id, int label, string datetime,
        decimal amount, decimal withdraw_amount, string sender, string sha1_hash, string currency, bool codepro)
        {
            string key = "xxxxxxxxxxxxxxxx"; // секретный код
                                             // проверяем хэш
            string paramString = String.Format("{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}&{8}",
                notification_type, operation_id, amount, currency, datetime, sender,
                codepro.ToString().ToLower(), key, label);
            string paramStringHash1 = GetHash(paramString);
            // создаем класс для сравнения строк
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            // если хэши идентичны, добавляем данные о заказе в бд
            if (0 == comparer.Compare(paramStringHash1, sha1_hash))
            {
                Orders order = _context.Orders.FirstOrDefault(o => o.OrderId == label);
                order.OrderOperation_Id = operation_id;
                order.OrderDate = DateTime.Now;
                order.OrderSumAll = amount;
                order.OrderSum = withdraw_amount;
                //order.Sender = sender;
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
        public string GetHash(string val)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] data = sha.ComputeHash(Encoding.Default.GetBytes(val));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public IActionResult Personal()
        {
            return View();
        }
        public async Task<IActionResult> Search(string goods)
        {
            
            IEnumerable<Good> goodlist = await _context.Good.Where(u => EF.Functions.Like(u.GoodName, "%"+goods+"%")).ToListAsync();
            //return RedirectToAction("Search","Home", goodslist);
            int i = count(goodlist);
            if (i>0)
            {
                return View(goodlist);
            }
            else
            {
                ViewData["Message"] = "Извините, товаров с данным наименование не найдено";
                return View();
            }
        }

        public int count(IEnumerable<Good> items)
        {
            int i = items.Count();
            return i;
        } 


        //public IActionResult Search(string goods)
        //{
        //    return View();
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
