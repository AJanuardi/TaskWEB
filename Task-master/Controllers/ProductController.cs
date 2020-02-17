using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Data;
using MVC.Models;

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
