using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private AppDbContext _appDbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var items = from i in _appDbContext.Cookies select i;
            ViewBag.items = items;
            return View();
        }

        public IActionResult Product()
        {
            var items = from i in _appDbContext.Cookies select i;
            ViewBag.items = items;
            var add = from i in _appDbContext.Carts select i;
            ViewBag.add = add;
            return View();
        }
        public IActionResult Cart()
        {
            var items = from i in _appDbContext.Carts select i;
            ViewBag.items = items;
            return View();
        }
        public IActionResult Add(int id)
        {
            var items = from i in _appDbContext.Cookies where i.id == id select i;
            ViewBag.items = items;
            foreach (var i in items)
            {
            var barang = new Cart()
            {
                nama = i.nama,
                harga = i.harga,
            };
            _appDbContext.Carts.Add(barang);
            }
            
            _appDbContext.SaveChanges();
            return RedirectToAction("Cart", "Home");
        }
        public IActionResult Data(string link)
        {
            Console.WriteLine("=============================================================");
            Console.WriteLine(link);
            return View();
        }
        public IActionResult Delete(int id)
        {
            var Delete = _appDbContext.Carts.Find(id);
            _appDbContext.Carts.Remove(Delete);
            _appDbContext.SaveChanges();
            return RedirectToAction("Cart","Home");
        }

        public IActionResult Admin(string nama, string password)
        {
            var items = from item in _appDbContext.Users select item;
            foreach (var x in items)
            {
                if (x.nama == nama)
                {
                    if (Convert.ToString(x.password) == password)
                    {
                        HttpContext.Session.SetString("username", nama);
                        return View("Success");
                    }
                    else
                    {
                        ViewBag.error = "Invalid Password";
                    }
                }
                else
                {
                    ViewBag.error = "Invalid Username";
                }
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Admin");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
