using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using B4P.Models;
using B4P.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace B4P.Controllers
{   
    [Authorize]
    public class PersonalController : Controller
    {
        private B4PTestContext _context;
        public PersonalController(B4PTestContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Orders()
        {

            IEnumerable<Orders> orders = await _context.Orders.Where(p => p.UserId == int.Parse(User.Identity.Name)).ToListAsync();
            return View(orders);
        }
        public async Task<IActionResult> Comments()
        {
            IEnumerable<Good> goods = from good in _context.Good join comment in _context.Comment on good.GoodsId equals comment.GoodsId where comment.UserId == int.Parse(User.Identity.Name) select good;
            List<string> comments = await _context.Comment.Where(p => p.UserId == int.Parse(User.Identity.Name)).Select(p => p.Comment1).ToListAsync();
            var model = new CommentModel
            {
                Goods = goods,
                Comment = comments

            };
            //List<string> comments = await _context.Comment.Where(p => p.UserId == int.Parse(User.Identity.Name)).Select(p => p.Comment1).ToListAsync(); 
            return View(model);
        }
        public async Task<IActionResult> Data()
        {
            var userDate = await _context.Users.FirstOrDefaultAsync(p => p.UserId == int.Parse(User.Identity.Name));
            return View(userDate);
        }
        [HttpPost]
        public async Task<IActionResult> Change(string email, string login, string name, string family,
            string lastname, DateTime birthday, string phone)
        {
            var user = await _context.Users.FirstOrDefaultAsync(p => p.UserId == int.Parse(User.Identity.Name));
            user.UserMail = email;
            user.UserLogin = login;
            user.UserName = name;
            user.UserFamily = family;
            user.UserLastName = lastname;
            user.UserBirthday = birthday;
            user.UserPhone = phone;
            await _context.SaveChangesAsync();
            return RedirectToAction("Data", "Personal");
        }

        [HttpPost]
        public async Task<IActionResult> ChangePas(ChangePasModel model) 
        {
            Users user = await _context.Users.Where(p => p.UserId == int.Parse(User.Identity.Name)).FirstOrDefaultAsync();
            if (ModelState.IsValid && user != null && user.UserPassword == model.OldPassword)
            {
                user.UserPassword = model.Password;
                await _context.SaveChangesAsync();
                return Content("Пароль изменен");
            }
            else return Content("Пароль не изменен");
            
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
