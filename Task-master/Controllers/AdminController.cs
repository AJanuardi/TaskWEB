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
    public class AdminController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IConfiguration Configuration;
        private AppDbContext _appDbContext;

        public AdminController(ILogger<HomeController> logger, AppDbContext appDbContext, IConfiguration configuration)
        {
            _logger = logger;
            _appDbContext = appDbContext;
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            return View("Login");
        }

        public IActionResult Login(string Email ,int Password )
        {
            IActionResult response = Unauthorized();

            var user = AuthenticatedUser(Email,Password);
            if(user != null)
            {
                var token = GenerateJwtToken(user);
                HttpContext.Session.SetString("JWTToken",token);
                var get = HttpContext.Session.GetString("JWTToken");
                return RedirectToAction("Data","Admin");
            }
            return View();
        }

        private string GenerateJwtToken(User user)
        {
            var secuityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(secuityKey,SecurityAlgorithms.HmacSha256);
            
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,Convert.ToString(user.email)),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer:Configuration["Jwt:Issuer"],
                audience:Configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials:credentials);

            var encodedToken = new JwtSecurityTokenHandler().WriteToken(token);
            
            return encodedToken;
        }

        private User AuthenticatedUser(string Email,int Password)
        {
            User user = null;
            var x = from i in _appDbContext.Users select new {i.nama,i.email,i.password};
            foreach(var i in x)
            {
                if(i.email == Email && (i.password == Password))
                {
                    user = new User
                    {
                        email = Email,
                        password = Password,
                    };
                }
            }
            return user;
        }

        [Authorize]
        public IActionResult Data()
        {
            var token = HttpContext.Session.GetString("JWTToken");
            var jwtSec  = new JwtSecurityTokenHandler();
            var securityToken = jwtSec.ReadToken(token) as JwtSecurityToken;
            var sub = securityToken?.Claims.First(Claim => Claim.Type == "sub").Value;
            var items = from i in _appDbContext.Cookies select i;
            ViewBag.items = items;
            ViewBag.username = sub;
            return View();
        }

        [Authorize]
        public IActionResult Add(int Rating, string Nama, string Foto, string Deskripsi, int Harga)
        {
            if(Nama!=null)
            {
            Cookie cookies = new Cookie()
            {
                rating = Rating,
                nama = Nama,
                foto = Foto,
                deskripsi = Deskripsi,
                harga = Harga
            };
            _appDbContext.Cookies.Add(cookies);
            _appDbContext.SaveChanges();
            }
            return View();
        }
        
        [Authorize]
        public IActionResult Edit()
        {
            var items = from i in _appDbContext.Cookies select i;
            ViewBag.items = items;
            return View("Editor", "Admin");
        }

        [Authorize]
        public ActionResult Editor(int id, int rating, string nama, string foto, string deskripsi, int harga)
        {
            var x = _appDbContext.Cookies.Find(id);
            x.nama = nama;
            x.rating = rating;
            x.foto = foto;
            x.deskripsi = deskripsi;
            x.harga = harga;
            _appDbContext.SaveChanges();
            return RedirectToAction("Data", "Admin");
        }

        [Authorize]
        public IActionResult Remove(int id)
        {
          var items = _appDbContext.Cookies.Find(id);
          _appDbContext.Remove(items);
          _appDbContext.SaveChanges();
          return RedirectToAction("Data","Admin");
        }

        [Authorize]
        public IActionResult Export()
        {
            var colom = new string[]
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
            byte[] buffer = Encoding.ASCII.GetBytes($"{string.Join(",", colom)}\r\n{cookies.ToString()}");
            return File(buffer, "text/csv", $"Cookie.csv");
        }

        [Authorize]
        public IActionResult Import([FromForm(Name="Upload")] IFormFile Upload)
        {
                        using (var sreader = new StreamReader(Upload.OpenReadStream()))
                        {
                            string[] headers = sreader.ReadLine().Split(',');
                            while(!sreader.EndOfStream)
                            {
                                string[] rows = sreader.ReadLine().Split(',');
                                foreach(var x in rows)
                                {
                                    Console.WriteLine(x);
                                }
                                Cookie cookie = new Cookie()
                                {
                                    rating = int.Parse(rows[0].ToString()),
                                    nama = rows[1].ToString(),
                                    foto = rows[2].ToString(),
                                    deskripsi =rows[3].ToString(),
                                    harga = int.Parse(rows[4])
                                };
                                _appDbContext.Cookies.Add(cookie);
                            }
                            _appDbContext.SaveChanges();
                        }
                        return RedirectToAction("Data", "Admin");
        }

        [Authorize]
        public IActionResult Transaction()
        {
            var x = from i in _appDbContext.Transactions select i;
            ViewBag.items = x;
            return View("Transaction", "Admin");
        }

        [Authorize]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("JWTToken");
            return RedirectToAction("Product","Home");   
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
