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

        public IActionResult Product(int Sort,int? page,int PerPage,string Search = "")
        {

            ViewBag.Sort = Sort;
            ViewBag.Search = Search;
            ViewBag.PerPage = PerPage;

            if(!String.IsNullOrEmpty(Search))
            {
               var item = from l in _appDbContext.Cookies where l.nama.Contains(Search) || l.deskripsi.Contains(Search) select l;
               var pager = new Pager(item.Count(), page);
               var viewModel = new IndexViewModel
                {
                    Cookies = item.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                    Pager = pager
                };
                return View(viewModel);
            }
            if(Sort != 0)
            {
                var x = Sorting(Sort,page);
                return View(x);
            }
            if(PerPage != 0)
            {
                var item = from l in _appDbContext.Cookies select l;
                var pager = new Pager(item.Count(),page,PerPage);
                var viewModel = new IndexViewModel
                {
                    Cookies = item.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                    Pager = pager
                };
                return View(viewModel);
            }
            else
            {
               var item = from l in _appDbContext.Cookies select l;
               var pager = new Pager(item.Count(), page);
               var viewModel = new IndexViewModel
                {
                    Cookies = item.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                    Pager = pager
                };
                return View(viewModel);
            }       
        }

        public IActionResult Cart()
        {
            var items = from i in _appDbContext.Carts select i;
            ViewBag.items = items;
            return View();
        }

        public IActionResult Charges(string name, string address, string phone, string email, int total)
        {
            var items = from i in _appDbContext.Transactions select i;
            ViewBag.items = items;
            var transc = from i in _appDbContext.Carts select i;
            ViewBag.transc = transc;
            Console.WriteLine("=========================");
            Console.WriteLine(total);
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(email);
            Transaction harga = new Transaction()
            {
                name = name,
                address = address,
                email = email,
                phone = phone,
                total = total
            };
            _appDbContext.Transactions.Add(harga);
            _appDbContext.SaveChanges();
            
            return View("Payment");
        }

        public IActionResult Payment(string stripeEmail, string stripeToken)
        {
            var customer = new CustomerService();
            var charges = new ChargeService();
            var customers = customer.Create(new CustomerCreateOptions{
                Email = stripeEmail,
                Source = stripeToken
            });
            var x = from i in _appDbContext.Transactions.OrderByDescending(a => a.id) select i;
            foreach (var i in x)
            {
            var charge = charges.Create(new ChargeCreateOptions{
                Amount = (i.total*100),
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
            var y = from i in _appDbContext.Carts select i;
            foreach (var i in y)
            {
            _appDbContext.Carts.RemoveRange(i);
            }
            _appDbContext.SaveChanges();
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

        public IndexViewModel Sorting(int Sort,int? page)
        {   
            var value = Sort;
            ViewBag.Sort = value;
    
            if(Sort == 1)
            {
                var data = _appDbContext.Cookies.OrderBy(u => u.nama);
                var pager = new Pager(data.Count(), page);
                var viewModel = new IndexViewModel
                {
                    Cookies = data.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                    Pager = pager
                };
                return (viewModel);
            }
            if(Sort == 2)
            {
                var data = _appDbContext.Cookies.OrderByDescending(u => u.nama);
                var pager = new Pager(data.Count(), page);
                var viewModel = new IndexViewModel
                {
                    Cookies = data.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                    Pager = pager
                };
                return viewModel;  
            }
            if(Sort == 3)
            {
                var data = _appDbContext.Cookies.OrderBy(u => u.harga);
                var pager = new Pager(data.Count(), page);
                var viewModel = new IndexViewModel
                {
                    Cookies= data.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                    Pager = pager
                };
                return viewModel;
            }
            if(Sort == 4)
            {
                var data = _appDbContext.Cookies.OrderByDescending(u => u.harga);
                var pager = new Pager(data.Count(), page);
                var viewModel = new IndexViewModel
                {
                    Cookies = data.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                    Pager = pager
                };
                return viewModel;
            }
            else
            {
                var data = _appDbContext.Cookies;
                var pager = new Pager(data.Count(), page);
                var viewModel = new IndexViewModel
                {
                    Cookies = data.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                    Pager = pager
                };
                return viewModel;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
