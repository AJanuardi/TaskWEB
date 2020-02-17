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

        public IActionResult Charges(int total)
        {
            Console.WriteLine("=========================");
            Console.WriteLine(total);
            Total harga = new Total()
            {
                total = total
            };
            _appDbContext.Totals.Add(harga);
            _appDbContext.SaveChanges();
            
            return RedirectToAction("Check", "Home");
        }
        public IActionResult Check()
        {
            var items = from i in _appDbContext.Totals select i;
            ViewBag.items = items;
            var transc = from i in _appDbContext.Carts select i;
            ViewBag.transc = transc;
            return View("Checkout");
        }

        public IActionResult Checkout(string first, string last, string address, string country, string state, int zip, int totalBelanja)
        {
            System.Console.WriteLine("CEKBRO");
            Console.WriteLine("====================================");
            Console.WriteLine(first);
            Console.WriteLine(last);
            Console.WriteLine(address);
            Console.WriteLine(country);
            Console.WriteLine(state);
            Console.WriteLine(zip);
            Console.WriteLine(totalBelanja);
            Transaction harga = new Transaction()
            {
                konsumen = first+" "+last,
                alamat = address+" "+country,
                Province = state,
                PostalCode = zip,
                totalBelanja = totalBelanja
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
            var x = from i in _appDbContext.Totals select i;
            foreach (var i in x)
            {
            var charge = charges.Create(new ChargeCreateOptions{
                Amount = i.total,
                Description = "Test Payment",
                Currency = "idr",
                Customer = customers.Id
            });
            if (charge.Status == "succeeded")
            {
                string BalanceTransactionId = charge.BalanceTransactionId;
                return View("Success");
            }
            }
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Add(int id)
        {
            Console.WriteLine("=================================");
            Console.WriteLine(id);
            var items = from i in _appDbContext.Cookies where i.id == id select i;
            ViewBag.items = items;
            foreach (var i in items)
            {
            var barang = new Cart()
            {
                nama = i.nama,
                foto = i.foto,
                harga = i.harga,
                quantity = 0
            };
            _appDbContext.Carts.Add(barang);
            }
            _appDbContext.SaveChanges();
            return RedirectToAction("Cart", "Home");
        }

        public IActionResult Update (int id, int val) 
        {
            Console.WriteLine("=============================");
            Console.WriteLine(id);
            Console.WriteLine(val);
            var item = _appDbContext.Carts.Find(id);
            item.quantity = val;
            _appDbContext.Add (item);
            _appDbContext.Attach (item);
            _appDbContext.SaveChanges ();
            var display = from x in _appDbContext.Carts select x;
            ViewBag.items = display;
            return RedirectToAction ("Cart", "Home");
        }

        public IActionResult Delete(int id)
        {
            Console.WriteLine("===========================");
            Console.WriteLine(id);
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
