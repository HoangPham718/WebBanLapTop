using WebLapTop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace WebLapTop.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebLapTopContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, WebLapTopContext context)
        {
            _logger = logger;
            this._context = context;
        }

        public IActionResult Index()
        {
            try
            {
                var product = from anh in _context.Anhs
                              join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                              where anh.TenAnh.Contains("slider")
                              select new Anh
                              {
                                  MaAnh = "/img/"+anh.MaAnh+".png",
                                  MaSp=sp.MaSp,
                                  MaSpNavigation=sp,
                              };
                ViewBag.Anh = product.Take(4).ToList();
            }
            catch(Exception)
            {
                throw ;
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult ListProduct()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
