using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Data;
using MVC.Models;
using System.Web;
using System.IO;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private AppDbContext _appDbContext;

        public ProductController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public IActionResult Detail(int id)
        {
            var items = from item in _appDbContext.Cookies where item.id == id select item;
            ViewBag.items = items;
            return View("Detail");
        }

        public IActionResult Export()
        {
            var comlumHeadrs = new string[]
            {
                "id",
                "rating",
                "nama",
                "foto",
                "deskripsi",
                "harga"
            };

            var cookie = (from i in _appDbContext.Cookies select new object[]
            {
                i.id,
                i.rating,
                i.nama,
                i.foto,
                $"\"{i.deskripsi}\"",
                i.harga
            }).ToList();


            var cookies = new StringBuilder();
            cookie.ForEach(line =>
                {
                    cookies.AppendLine(string.Join(",", line));
                });
 
            byte[] buffer = Encoding.ASCII.GetBytes($"{string.Join(",", comlumHeadrs)}\r\n{cookies.ToString()}");
            return File(buffer, "text/csv", $"Cookie.csv");
        }
 
        public IActionResult Import([FromForm(Name="Upload")] IFormFile Upload)
        {
                        using (var sreader = new StreamReader(Upload.OpenReadStream()))
                        {
                            string[] headers = sreader.ReadLine().Split(',');
                            Console.WriteLine("===========================");
                           // Console.WriteLine(headers);
                            while(!sreader.EndOfStream)
                            {
                                string[] rows = sreader.ReadLine().Split(',');
                                foreach(var x in rows)
                                {
                                    Console.WriteLine(x);
                                }
                                Cookie cookie = new Cookie()
                                {
                                    rating = int.Parse(rows[1].ToString()),
                                    nama = rows[2].ToString(),
                                    foto = rows[3].ToString(),
                                    deskripsi =rows[4].ToString(),
                                    harga = int.Parse(rows[5])
                                };
                                _appDbContext.Cookies.Add(cookie);
                            }
                            _appDbContext.SaveChanges();
                        }
                        return RedirectToAction("Product", "Home");
        }
 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
