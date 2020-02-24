using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Data;
using MVC.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.IO;

namespace MVC.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IConfiguration Configuration;
        private AppDbContext _appDbContext;

        public CartController(ILogger<HomeController> logger, AppDbContext appDbContext, IConfiguration configuration)
        {
            _logger = logger;
            _appDbContext = appDbContext;
            Configuration = configuration;
        }

        public IActionResult Items()
        {
            var x = (from i in _appDbContext.Transactions where (i.status == "approve") select i).Count();
            ViewBag.approve = x;
            var y = (from i in _appDbContext.Transactions.OrderBy(a => a.id) where (i.status == "approve") select i).LastOrDefault();
            ViewBag.purchase = y;
            var z = from i in _appDbContext.Carts select i;
            ViewBag.cart = z;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
