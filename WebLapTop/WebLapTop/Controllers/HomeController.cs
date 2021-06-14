using WebLapTop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
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
            string logcheck = HttpContext.Session.GetString("EmailUser");
            if (String.IsNullOrEmpty(logcheck))
            {
                ViewData["Log"] = "";
            }
            else
            {
                ViewData["Log"] = logcheck;
            }
            try
            {
                var slide = from anh in _context.Anhs
                            join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                            where anh.TenAnh.Contains("slider")
                            select new Anh
                            {
                                MaAnh = "/img/" + anh.MaAnh + ".png",
                                MaSp = sp.MaSp,
                                MaSpNavigation = sp,
                            };
                ViewBag.Anh = slide.Take(4).ToList();

                var dsproduct = from anh in _context.Anhs
                                join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                                where anh.TenAnh.Contains("ảnh sp")
                                select new Anh
                                {
                                    MaAnh = "/img/" + anh.MaAnh + ".png",
                                    MaSp = sp.MaSp,
                                    MaSpNavigation = sp,
                                };
                ViewData["DSnew"] = dsproduct.Take(10).OrderByDescending(u => u.MaSpNavigation.NgayTao).ToList();
                var dsproduct2 = from anh in _context.Anhs
                                 join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                                 where anh.TenAnh.Contains("ảnh sp")
                                 select new Anh
                                 {
                                     MaAnh = "/img/" + anh.MaAnh + ".png",
                                     MaSp = sp.MaSp,
                                     MaSpNavigation = sp,
                                 };
                ViewData["DSprice"] = dsproduct2.Take(10).OrderByDescending(u => u.MaSpNavigation.DonGia).ToList();
            }
            catch (Exception)
            {
                throw;
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
            ViewData["Log"] = "";
            ViewData["Message"] = "";
            AccountLogin account = new AccountLogin();
            if (!String.IsNullOrEmpty(Request.Cookies["userName"]))
            {
                account.Email = Request.Cookies["userName"].ToString();
                account.MatKhau = Request.Cookies["userPass"].ToString()!=null ? Request.Cookies["userPass"].ToString():null;
                account.Remember = Request.Cookies["remember"].ToString()!=null? true:false ;
            }              
            ViewData["Account"] = account;
            return View();
        }
        public IActionResult Logout()
        {
            ViewData["Message"] = "";
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(AccountLogin log)
        {
            AccountLogin account = new AccountLogin();
            ViewData["Account"] = account;
            ViewData["Log"] = "";
            ViewData["Message"] = "";
            if (ModelState.IsValid)
            {
                try
                {

                    var userExist = _context.Khachhangs.Where(u => u.Email.Equals(log.Email)).Count();
                    if (userExist > 0)
                    {
                        var PassCheck = _context.Khachhangs.Where(u => u.Email.Equals(log.Email) && u.MatKhau.Equals(log.MatKhau));
                        if (PassCheck.Count() > 0)
                        {
                            if(log.Remember)
                            {
                                Response.Cookies.Append("userPass", log.MatKhau);
                                Response.Cookies.Append("remember", "y");
                            }
                            Response.Cookies.Append("userName", log.Email);
                            HttpContext.Session.SetString("EmailUser", log.Email);
                            HttpContext.Session.SetString("PassWord", log.MatKhau);
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ViewData["Message"] = "Sai mật khẩu";
                            return View();
                        }
                    }
                    else
                    {

                        ViewData["Message"] = "Không tìm thấy tài khoản";
                        return View();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                return View();
            }
        }
        public IActionResult Signup()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Detail(String MaSp)
        {
            try
            {
                var products = from anh in _context.Anhs
                               join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                               where anh.MaSp.Equals(MaSp)
                               select new Anh
                               {
                                   MaAnh = "/img/" + anh.MaAnh + ".png",
                                   MaSp = sp.MaSp,
                                   MaSpNavigation = sp,
                               };
                var product = products.FirstOrDefault();
                ViewBag.Anh = product;

                var BrandPros = from anh in _context.Anhs
                                join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                                where anh.MaSpNavigation.ThuongHieu.Equals(product.MaSpNavigation.ThuongHieu)
                                select new Anh
                                {
                                    MaAnh = "/img/" + anh.MaAnh + ".png",
                                    MaSp = sp.MaSp,
                                    MaSpNavigation = sp,
                                };
                ViewData["BrandPros"] = BrandPros.Take(8).OrderByDescending(u => u.MaSpNavigation.NgayTao).ToList();

                var RelativeProducts = from anh in _context.Anhs
                                       join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                                       where anh.MaSpNavigation.ThuongHieu.Equals(product.MaSpNavigation.ThuongHieu) || anh.MaSpNavigation.LoaiSp.Contains(anh.MaSpNavigation.LoaiSp)
                                       select new Anh
                                       {
                                           MaAnh = "/img/" + anh.MaAnh + ".png",
                                           MaSp = sp.MaSp,
                                           MaSpNavigation = sp,
                                       };
                ViewData["RelativePros"] = RelativeProducts.Take(8).OrderByDescending(u => u.MaSpNavigation.NgayTao).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult ListProduct(String keyword)
        {
            ViewData["Log"] = "";
            ViewData["Message"] = "";
            string keyquery="";
            if (String.IsNullOrEmpty(keyword))
            {
                keyquery = "";
            }
            else
            {
                keyquery= keyword.Trim().ToLower()+"";
            }
            try
            {
                
                var products = from anh in _context.Anhs
                               join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                               where anh.MaSp.ToLower().Contains(keyquery) ||  anh.MaSpNavigation.LoaiSp.Trim().ToLower().Contains(keyquery) 
                               || anh.MaSpNavigation.ThuongHieu.Trim().ToLower().Contains(keyquery) ||keyquery.Contains(anh.MaSpNavigation.ThuongHieu.Trim().ToLower())
                               || keyquery.Contains(anh.MaSpNavigation.LoaiSp.Trim().ToLower())
                               select new Anh
                               {
                                   MaAnh = "/img/" + anh.MaAnh + ".png",
                                   MaSp = sp.MaSp,
                                   MaSpNavigation = sp,
                               };
                ViewData["key"] = keyword;
                ViewBag.Anh = products.ToList();
            }
            catch(Exception)
            {
                throw;
            }

            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}