using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Web;
using MVC.Data;
using MVC.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using Stripe;

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

        public IActionResult Product(string sort)
        {
            var items = from i in _appDbContext.Cookies select i;
            ViewBag.items = items;
            return View();
        }

        public IActionResult Cart()
        {
            var items = from i in _appDbContext.Carts select i;
            ViewBag.items = items;
            return View();
        }

        public IActionResult Charge(int total)
        {
            System.Console.WriteLine("==========================================");
            System.Console.WriteLine(total);
            Transaction harga = new Transaction()
            {
                jumlahHarga = total
            };
            _appDbContext.Transactions.Add(harga);
            _appDbContext.SaveChanges();
            return View("Purchase");
        }

        public IActionResult Purchase(string stripeEmail, string stripeToken)
        {
            var customer = new CustomerService();
            var charges = new ChargeService();
            var customers = customer.Create(new CustomerCreateOptions{
                Email = stripeEmail,
                Source = stripeToken
            });
            var x = from i in _appDbContext.Transactions select i;
            foreach (var i in x)
            {
            var charge = charges.Create(new ChargeCreateOptions{
                Amount = i.jumlahHarga,
                Description = "Test Payment",
                Currency = "usd",
                Customer = customers.Id
            });
            if (charge.Status == "succeeded")
            {
                string BalanceTransactionId = charge.BalanceTransactionId;
                return View();
            }
            else
            {
                
            }
            }
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

        public IActionResult Delete(int id)
        {
            var Delete = _appDbContext.Carts.Find(id);
            _appDbContext.Carts.Remove(Delete);
            _appDbContext.SaveChanges();
            return RedirectToAction("Cart","Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
