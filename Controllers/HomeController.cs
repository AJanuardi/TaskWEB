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
using System.Net;
using System.Net.Mail;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit;

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
            var items = from i in _appDbContext.Transactions.OrderBy(a=>a.id) select i;
            var last = items.LastOrDefault();
            ViewBag.total = last.total;
            ViewBag.nama = last.name;
            ViewBag.alamat = last.address;
            ViewBag.email = last.email;
            ViewBag.phone = last.phone;
            var transc = from i in _appDbContext.Carts select i;
            ViewBag.transc = transc;
            
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
                return RedirectToAction("Success", "Home");
            }
            }
            return View();
        }

        public IActionResult Success()
        {
            var message = new MimeMessage();
            var x = from i in _appDbContext.Transactions.OrderBy(a => a.id) select i;
            var last = x.LastOrDefault();
            var nama = last.name;
            var email = last.email;
            var total = last.total;
            message.To.Add(new MailboxAddress(nama, email));
            message.From.Add(new MailboxAddress("Cookies", "cookies@cookies.com"));
            message.Subject = "Invoice Cookies Store";
            message.Body = new TextPart("plain")
            {
                Text = @"Hey "+nama+",\n"
                +"Thanks for Purchasing your Favorite Cookies from Us\n"
                +"Here's the Details:\n"
                +"Amount: Rp."+total+",-\n"
            };
            using (var emailClient = new MailKit.Net.Smtp.SmtpClient())
            {
                emailClient.ServerCertificateValidationCallback = (s,c,h,e) => true;

                emailClient.Connect("smtp.mailtrap.io", 587, false);

                emailClient.Authenticate("4f39759a75dd18","7e295fd331c5b6");

                emailClient.Send(message);

                emailClient.Disconnect(true);
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
