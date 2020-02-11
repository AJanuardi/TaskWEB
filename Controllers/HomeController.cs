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
        public IActionResult Link(string link)
        {
            if (link == "b")
            {
                var items = from i in _appDbContext.Cookies.Skip(4).Take(4) select i;
                ViewBag.items = items;
                return View("Link", "Home");
            }
            else if (link == "c")
            {
                var items = from i in _appDbContext.Cookies.Skip(8).Take(4) select i;
                ViewBag.items = items;
                return View("Link", "Home");
            }
             else if (link == "d")
            {
                var items = from i in _appDbContext.Cookies.Skip(12).Take(4) select i;
                ViewBag.items = items;
                return View("Link", "Home");
            }
             else
            {
                var items = _appDbContext.Cookies.Take(4);
                ViewBag.items = items;
                return View("Link", "Home");
            }
        }

        public IActionResult Product(string sort)
        {
            var items = from i in _appDbContext.Cookies.Take(4) select i;
            ViewBag.items = items;
            if (sort == "a")
            {
                var x = from i in _appDbContext.Cookies.Take(4) select i;
                ViewBag.x = x;
                return View("Indexing","Home"); 
            }
            else if (sort == "b")
            {
                var x = _appDbContext.Cookies.OrderBy(x => x.nama).Take(4);
                ViewBag.x = x;
                return View("Indexing","Home");
            }
            else if (sort == "c")
            {
                var x = _appDbContext.Cookies.OrderByDescending(x => x.nama).Take(4);
                ViewBag.x = x;
                return View("Indexing","Home");
            }
            else if (sort == "d")
            {
                var x = _appDbContext.Cookies.OrderBy(x => x.harga).Take(4);
                ViewBag.x = x;
                return View("Indexing","Home");
            }
            else if (sort == "e")
            {
                System.Console.WriteLine("===========================================");
                System.Console.WriteLine(sort);
                var x = _appDbContext.Cookies.OrderByDescending(x => x.harga).Take(4);
                ViewBag.x = x;
                return View("Indexing", "Home");
            }
            return View ("Product", "Home");
        }

        public IActionResult Cart()
        {
            var items = from i in _appDbContext.Carts select i;
            ViewBag.items = items;
            return View();
        }
        public IActionResult Search(string Search)
        {
            System.Console.WriteLine("======================================");
            System.Console.WriteLine(Search);
            var items = from i in _appDbContext.Cookies where (i.nama.Contains(Search) || i.deskripsi.Contains(Search)) select i;
            ViewBag.items = items;
            System.Console.WriteLine("======================================");
            System.Console.WriteLine(items);
            return View("Search", "Home");
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

       public ActionResult Editor(int id, int rating, string nama, string foto, string deskripsi, int harga)
        {
            var x = _appDbContext.Cookies.Find(id);
            x.nama = nama;
            x.rating = rating;
            x.foto = foto;
            x.deskripsi = deskripsi;
            x.harga = harga;
            _appDbContext.SaveChanges();
            return RedirectToAction("Admin", "Home");
        }

        [HttpPost]
        public IActionResult Insert(Cookie obj)
        {
            Cookie objreg = new Cookie();
            string result = objreg.InsertCookies(obj);
            ViewData["result"] = result;
            ModelState.Clear();
            return View("Data");
        }
        public IActionResult Delete(int id)
        {
            var Delete = _appDbContext.Carts.Find(id);
            _appDbContext.Carts.Remove(Delete);
            _appDbContext.SaveChanges();
            return RedirectToAction("Cart","Home");
        }

        public IActionResult Edit()
        {
            var items = from i in _appDbContext.Cookies select i;
            ViewBag.items = items;
            return View("Editor");
        }
        public IActionResult List()
        {
            var items = from i in _appDbContext.Cookies select i;
            ViewBag.items = items;
            return View();
        }

        public ActionResult Del(int id)
        {
            Cookie cookieDetail = _appDbContext.Cookies.Find(id);
            _appDbContext.Cookies.Remove(cookieDetail);
            _appDbContext.SaveChanges();
            return RedirectToAction("Admin","Home");
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
