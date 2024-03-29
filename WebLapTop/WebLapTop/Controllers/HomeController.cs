﻿using WebLapTop.Models;
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


        public String findNameUser(string email)
        {
            var user = _context.Khachhangs.FirstOrDefault(u => u.Email.Equals(email));//truy vấn tìm tên user
            return user.TenKh.Split(" ").Last();
        }
        public int countCart()
        {
            string email = LogCheck();
            if (string.IsNullOrEmpty(email))
            {
                return 0;
            }
            var countC = _context.OrderCarts.Where(u=>u.email.Equals(email)).Sum(u => u.SL);// truy vấn tìm số lượng hàng hóa có trong giỏ
            return countC;
        }
        public IActionResult Index()
        {
            TempData["Coupon"] = null;
            HttpContext.Session.SetInt32("CountCart", countCart());// lưu số hàng hóa đã đặt bỏ vào view
            TempData["Route"] = "Index";//dùng để lưu lại trang người dùng đang sử dụng

            ViewData["AlertBill"] = "";//khởi tạo dử liệu để hiện thông báo phần thanh toán
            if (TempData["AlertBill"] != null)
            {
                ViewData["AlertBill"] = TempData["AlertBill"];
                TempData["AlertBill"] = null;
            }

            String email = LogCheck();//kiểm tra đăng nhập , lấy thông tin tài khoản
            ViewData["Log"] = email;
            if (!String.IsNullOrEmpty(email))
            {
                TempData["UserName"] = findNameUser(email);
            }


            try
            {
                //truy vấn dử liệu đổ lên các danh mục cần thiết
                var slide = from anh in _context.Anhs
                            join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                            where anh.TenAnh.Contains("slider")
                            select new Anh
                            {
                                MaAnh = "/img/" + anh.MaAnh + ".png",
                                MaSp = sp.MaSp,
                                MaSpNavigation = sp,
                            };
                ViewBag.Anh = slide.Take(4).ToList();// ds sản phẩm trên slide

                var dsproduct = from anh in _context.Anhs
                                join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                                where anh.TenAnh.Contains("ảnh sp")
                                select new Anh
                                {
                                    MaAnh = "/img/" + anh.MaAnh + ".png",
                                    MaSp = sp.MaSp,
                                    MaSpNavigation = sp,
                                };
                ViewData["DSnew"] = dsproduct.Take(10).OrderByDescending(u => u.MaSpNavigation.NgayTao).ToList();//ds sản phẩm mới
                var dsproduct2 = from anh in _context.Anhs
                                 join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                                 where anh.TenAnh.Contains("ảnh sp")
                                 select new Anh
                                 {
                                     MaAnh = "/img/" + anh.MaAnh + ".png",
                                     MaSp = sp.MaSp,
                                     MaSpNavigation = sp,
                                 };
                ViewData["DSprice"] = dsproduct2.Take(10).OrderByDescending(u => u.MaSpNavigation.DonGia).ToList();//ds sản phẩm theo giá giảm dần
            }
            catch (Exception)
            {
                throw;
            }
            return View();
        }

        public IActionResult InfoAccount()
        {
            string email = LogCheck();//lấy thông tin tài khoản đang đăng nhập
            ViewData["Log"] = email;


            //kiểm tra xem cho phép cập nhập chưa
            if (TempData["RemoveReadonly"] != null)
            {
                ViewData["RemoveReadonly"] = true;
                TempData["RemoveReadonly"] = null;
            }
            //kiểm tra sdt
            if (TempData["ValidPhone"] != null)
            {
                ViewData["ValidPhone"] = TempData["ValidPhone"];
                TempData["ValidPhone"] = null;
            }
            var info = _context.Khachhangs.FirstOrDefault(u => u.Email.Equals(email));// lấy thông tin tài khoản

            var mota = _context.Khuyenmais.FirstOrDefault(u => u.MaKm == info.MaKm).MoTa;//lấy thông tin của khuyển mãi
            if (mota != null)
                ViewData["mota"] = mota;
            else
                ViewData["mota"] = "Không có khuyến mãi nào!";

            return View(info);
        }
        public IActionResult Cart()
        {
            TempData["Route"] = "Cart";
            String email = LogCheck();
            if(string.IsNullOrEmpty(email))
            {
                return RedirectToAction("Login");
            }
            ViewData["Log"] = email;



            try
            {

                var cart = _context.OrderCarts.Where(u => u.email.Equals(email)).ToList();

                String Masp;
                //check order
                if (cart.Count == 0)
                {
                    Masp = "SP01";
                }
                else
                {
                    Masp = cart.FirstOrDefault().MaSp;
                }

                //check km, get data khuyenmai
                var checkKM = _context.OrderCarts.Where(u=>u.email.Equals(email)).FirstOrDefault();
                if (checkKM != null)
                {
                    if (checkKM.MaKm != 0 && !String.IsNullOrEmpty(email))
                    {
                        var khuyenmai = _context.Khuyenmais.FirstOrDefault(u => u.MaKm == checkKM.MaKm);
                        ViewData["Coupon"] = khuyenmai;
                        TempData["Coupon"] = null;
                    }
                    else
                    {
                        checkKM.MaKm = 0;
                        _context.SaveChanges();
                        ViewData["Coupon"] = TempData["Coupon"] != null ? TempData["Coupon"] : "";
                        TempData["Coupon"] = null;
                    }
                }
                else
                {
                    ViewData["Coupon"] = TempData["Coupon"];
                    TempData["Coupon"] = null;
                }
                //cart k co gi ma nhap coupon
                ViewData["AlertOrder"] = "";
                if (TempData["AlertOrder"] != null)
                {
                    ViewData["AlertOrder"] = TempData["AlertOrder"];
                    TempData["AlertOrder"] = null;
                }
                //het hang
                if(TempData["ErrorUpdate"]!=null)
                {
                    ViewData["ErrorUpdate"] = TempData["ErrorUpdate"];
                    TempData["ErrorUpdate"] = null;
                }

                //get data
                var product = _context.Sanphams.FirstOrDefault(u => u.MaSp.Equals(Masp));

                var BrandPros = from anh in _context.Anhs
                                join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                                where anh.MaSpNavigation.ThuongHieu.Equals(product.ThuongHieu)
                                select new Anh
                                {
                                    MaAnh = "/img/" + anh.MaAnh + ".png",
                                    MaSp = sp.MaSp,
                                    MaSpNavigation = sp,
                                };
                ViewData["BrandPros"] = BrandPros.Take(4).OrderByDescending(u => u.MaSpNavigation.NgayTao).ToList();

                var RelativeProducts = from anh in _context.Anhs
                                       join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                                       where anh.MaSpNavigation.ThuongHieu.Equals(product.ThuongHieu) || anh.MaSpNavigation.LoaiSp.Contains(product.LoaiSp)
                                       select new Anh
                                       {
                                           MaAnh = "/img/" + anh.MaAnh + ".png",
                                           MaSp = sp.MaSp,
                                           MaSpNavigation = sp,
                                       };
                ViewData["RelativePros"] = RelativeProducts.Take(8).OrderByDescending(u => u.MaSpNavigation.NgayTao).ToList();

                //get total order
                var totalOrder = _context.OrderCarts.Where(u => u.email.Equals(email)).Sum(u => u.DonGia * u.SL);


                ViewData["Total"] = totalOrder;

                ViewBag.OrderCart = cart;



            }
            catch (Exception)
            {
                throw;
            }
            return View();
        }
        public IActionResult Checkout()
        {
            TempData["Route"] = "Checkout";
            String email = LogCheck();
            ViewData["Log"] = email;



            if (String.IsNullOrEmpty(email))
            {
                var reset = _context.OrderCarts.Where(u => u.email.Equals(email)).FirstOrDefault();
                reset.MaKm = 0;
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            //coupon check
            var checkCoupon = _context.OrderCarts.Where(u => u.email.Equals(email)).FirstOrDefault();

            if (checkCoupon != null)
            {
                ViewData["CouponCode"] = checkCoupon.MaKm;
                var coupon = _context.Khuyenmais.FirstOrDefault(u => u.MaKm == checkCoupon.MaKm);
                ViewData["CouponDetail"] = coupon;
            }
            else
            {
                ViewData["CouponDetail"] = null;
                return RedirectToAction("Cart");
            }

            //get info account

            var info = _context.Khachhangs.FirstOrDefault(u => u.Email.Equals(email));
            ViewData["InfoCustomer"] = info;

            //get cart,total ; check cart before

            var cart = _context.OrderCarts.Where(u => u.email.Equals(email)).ToList();


            ViewBag.OrderCart = cart;
            ViewData["Total"] = _context.OrderCarts.Where(u => u.email.Equals(email)).Sum(u => u.DonGia * u.SL);

            //get data sidebar
            var product = _context.Sanphams.FirstOrDefault(u => u.MaSp.Equals(checkCoupon.MaSp));
            var RelativeProducts = from anh in _context.Anhs
                                   join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                                   where anh.MaSpNavigation.ThuongHieu.Equals(product.ThuongHieu) || anh.MaSpNavigation.LoaiSp.Contains(product.LoaiSp)
                                   select new Anh
                                   {
                                       MaAnh = "/img/" + anh.MaAnh + ".png",
                                       MaSp = sp.MaSp,
                                       MaSpNavigation = sp,
                                   };
            ViewData["RelativePros"] = RelativeProducts.Take(6).OrderByDescending(u => u.MaSpNavigation.NgayTao).ToList();


            return View();
        }
        [HttpPost]
        public IActionResult AddBill(Hoadon order)
        {
            //get data bill
            string email = LogCheck();
            var findKH = _context.Khachhangs.FirstOrDefault(u => u.Email.Equals(email));
            var lastMa = _context.Hoadons.OrderBy(u => u.MaHd).LastOrDefault().MaHd;
            int lstid = Convert.ToInt32(lastMa.Substring(2));

            Hoadon bill = new Hoadon()
            {
                MaHd = lstid > 9 ? "HD" + (lstid + 1) : "HD0" + (lstid + 1),
                MaKh = findKH.MaKh,
                NgayLap = DateTime.Now,
                shipping = order.shipping,
                TenNn = order.TenNn,
                DiaChi = order.DiaChi,
                Sdtnn = order.Sdtnn,
                shippingNote = order.shippingNote,
                TrangThai = 0
            };
            //tao bill
            _context.Hoadons.Add(bill);

            //get data order
            var listOrder = _context.OrderCarts.Where(u => u.email.Equals(email)).ToList();
            int checkKm = listOrder.FirstOrDefault().MaKm;
            int LoaiKm;
            if (checkKm == 0)
            {
                LoaiKm = 0;
            }
            else
            {
                LoaiKm = _context.Khuyenmais.FirstOrDefault(u => u.MaKm == checkKm).LoaiKm.Value;
            }


            // add billdetail
            foreach (var item in listOrder)
            {
                Chitiethoadon chitiethoadon = new Chitiethoadon()
                {
                    MaHd = bill.MaHd,
                    MaSp = item.MaSp,
                    DonGia = item.DonGia,
                    SoLuong = item.SL,
                    TienKm = LoaiKm * item.DonGia * item.SL / 100,
                    ThanhTien = (100 - LoaiKm) * item.DonGia * item.SL / 100
                };

                _context.Chitiethoadons.Add(chitiethoadon);

                ////remove soluong tu kho
                //var kho = _context.KhoSanphams.Where(u => u.MaSp == chitiethoadon.MaSp).Sum(u => u.SoLuong);
                //kho = kho - chitiethoadon.SoLuong;

                //var updateKho = _context.KhoSanphams.Where(u => u.MaSp == chitiethoadon.MaSp).ToList();

                //double total = 0;
                //foreach (KhoSanpham sanpham in updateKho)
                //{
                //    total = total + sanpham.SoLuong.Value;
                //    if (total >= chitiethoadon.SoLuong)
                //    {
                //        sanpham.SoLuong = kho;
                //        break;
                //    }
                //    sanpham.SoLuong = 0;
                //}

            }
            _context.OrderCarts.RemoveRange(listOrder);
            _context.SaveChanges();
            TempData["AlertBill"] = "Sucess";
            return RedirectToAction("Index");
        }
        public IActionResult Login()
        {
            

            ViewData["Log"] = "";
            AccountLogin account = new AccountLogin();
            if (!string.IsNullOrEmpty(Request.Cookies["userName"]))
            {
                account.Email = Request.Cookies["userName"].ToString();
                account.MatKhau = Request.Cookies["userPass"].ToString() == "none" ? null : Request.Cookies["userPass"].ToString();
                account.Remember = Request.Cookies["remember"].ToString() != "none";
            }
            ViewData["Account"] = account;
            return View();
        }
        public IActionResult Logout()
        {
            string email = LogCheck();
            HttpContext.Session.Clear();
            HttpContext.Session.SetInt32("CountCart", countCart());
            TempData["Coupon"] = null;
            var resetCoupon = _context.OrderCarts.Where(u => u.email.Equals(email)).FirstOrDefault();
            if (resetCoupon! != null)
            {
                resetCoupon.MaKm = 0;
                _context.SaveChanges();
            }
            return RedirectToAction("Login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(AccountLogin log)
        {
            AccountLogin account = new AccountLogin();
            ViewData["Account"] = account;
            ViewData["Log"] = "";
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
                            if (log.Remember)
                            {
                                Response.Cookies.Append("userPass", log.MatKhau);
                                Response.Cookies.Append("remember", "y");
                            }
                            else
                            {
                                Response.Cookies.Append("userPass", "none");
                                Response.Cookies.Append("remember", "none");
                            }
                            Response.Cookies.Append("userName", log.Email);
                            HttpContext.Session.SetString("EmailUser", log.Email);
                            HttpContext.Session.SetString("PassWord", log.MatKhau);
                            HttpContext.Session.SetString("UserName", findNameUser(log.Email));

                            HttpContext.Session.SetInt32("CountCart", countCart());
                            return RedirectToAction(TempData["Route"].ToString());
                        }
                        else
                        {
                            ModelState.AddModelError("Matkhau", "Sai mật khẩu");
                        }
                    }
                    else
                    {

                        ModelState.AddModelError("Email", "Không tìm thấy tài khoản");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return View();

        }
        public IActionResult Signup()
        {
            ViewData["Log"] = "";
            return View();
        }
        [HttpPost]
        public IActionResult Signup(KhachHangValid kh)
        {
            ViewData["Log"] = "";
            if (ModelState.IsValid)
            {
                var emailExist = _context.Khachhangs.FirstOrDefault(u => u.Email.Equals(kh.Email));
                if (emailExist == null)
                {
                    int lastId = Convert.ToInt32(_context.Khachhangs.OrderBy(u => u.MaKh).LastOrDefault().MaKh.Substring(2));
                    var insert = _context.Khachhangs.Add(new Khachhang
                    {
                        MaKh = lastId > 9 ? "KH" + (lastId + 1) : "KH0" + (lastId + 1),
                        MaKm = 1,
                        TenKh = kh.TenKh,
                        Email = kh.Email,
                        MatKhau = kh.MatKhau,
                        Sdt = kh.Sdt,
                        DiaChi = kh.soNha + "," + kh.xaP + "," + kh.quanH + "," + kh.tinhTP,
                        Diem = 0,
                        LoaiKh = "New",
                        TrangThai = true
                    });
                    _context.SaveChanges();
                    HttpContext.Session.SetString("EmailUser", kh.Email);
                    HttpContext.Session.SetString("PassWord", kh.MatKhau);
                    HttpContext.Session.SetString("UserName", findNameUser(kh.Email));
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("Email", "Email đã tồn tại");
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Detail(String MaSp)
        {
            TempData["Route"] = "Detail";
            String email = LogCheck();
            ViewData["Log"] = email;


            ViewData["Order"] = "";
            //order
            if (TempData["RouteDetail"] != null)
            {
                MaSp = TempData["RouteDetail"].ToString();
                TempData["RouteDetail"] = null;
            }
            if (TempData["Order"] != null)
            {
                ViewData["Order"] = TempData["Order"];
                TempData["Order"] = null;
            }

            //check sl
            if (TempData["OutOfStock"] != null)
            {
                ViewData["OutOfStock"] = TempData["OutOfStock"];
                ViewData["Sl"] = TempData["SL"];

                TempData["SL"] = null;
                TempData["OutOfStock"] = null;
            }

            var checkPro = _context.KhoSanphams.Where(u => u.MaSp == MaSp).Sum(u => u.SoLuong);
            ViewData["InStock"] = checkPro;

            try
            {
                var products = from anh in _context.Anhs
                               join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                               where anh.MaSp.Equals(MaSp)
                               select new Anh
                               {
                                   MaAnh = anh.MaAnh,
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
                ViewData["BrandPros"] = BrandPros.Take(4).OrderByDescending(u => u.MaSpNavigation.NgayTao).ToList();

                var RelativeProducts = from anh in _context.Anhs
                                       join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                                       where anh.MaSpNavigation.ThuongHieu.Equals(product.MaSpNavigation.ThuongHieu) || anh.MaSpNavigation.LoaiSp.Contains(product.MaSpNavigation.LoaiSp)
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
            TempData["Route"] = "Contact";
            String email = LogCheck();
            ViewData["Log"] = email;

            return View();
        }
        public IActionResult ListProduct(String keyword, int? page)
        {
            TempData["Route"] = "ListProduct";
            //check login 
            ViewData["Log"] = LogCheck();
            string keyquery = "";

            //page

            if (page == null || page < 1) page = 1;

            int pageSize = 12;
            int pageNumber = page.Value;

            if (String.IsNullOrEmpty(keyword))
            {
                keyquery = "";
            }
            else
            {
                keyquery = keyword.Trim().ToLower();
            }
            try
            {

                var products = from anh in _context.Anhs
                               join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                               where anh.MaSpNavigation.LoaiSp.Trim().ToLower().Contains(keyquery + "")
                               || anh.MaSpNavigation.ThuongHieu.Trim().ToLower().Contains(keyquery) || keyquery.Contains(anh.MaSpNavigation.ThuongHieu.Trim().ToLower() + "")
                               || keyquery.Contains(anh.MaSpNavigation.LoaiSp.Trim().ToLower()) || keyquery.Contains(anh.MaSpNavigation.TenSp.Trim().ToLower())
                                || anh.MaSpNavigation.TenSp.Trim().ToLower().Contains(keyquery)
                               select new Anh
                               {
                                   MaAnh = "/img/" + anh.MaAnh + ".png",
                                   MaSp = sp.MaSp,
                                   MaSpNavigation = sp,
                               };
                ViewData["key"] = keyword;
                products = products.OrderByDescending(u => u.MaSpNavigation.NgayTao);

                ViewData["Page"] = page;
               int countPage= products.Count() / pageSize;
                ViewData["MaxPage"] = countPage>0? countPage:1;
                int skip = (page.Value - 1) * pageSize;
                ViewBag.Anh = products.Skip(skip).Take(pageSize);

            }
            catch (Exception)
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
        public String LogCheck()
        {
            string logcheck = HttpContext.Session.GetString("EmailUser");
            string log;
            if (String.IsNullOrEmpty(logcheck))
            {
                log = "";
            }
            else
            {
                log = logcheck;
            }
            return log;
        }
        [HttpPost]
        public IActionResult AddToCart(OrderCart order)
        {
            string email = LogCheck();        
            if (string.IsNullOrEmpty(email))
            {
                TempData["RouteDetail"] = order.MaSp;
                return RedirectToAction("Login");
            }

            order.email = email;
            //check sp in order ?
            var checkOrder = _context.OrderCarts.FirstOrDefault(u => u.MaSp.Equals(order.MaSp)&&u.email.Equals(email));
            //check sl con lai
            var checkPro = _context.KhoSanphams.Where(u => u.MaSp == order.MaSp).Sum(u => u.SoLuong);

            TempData["RouteDetail"] = order.MaSp;

            if (checkPro < order.SL)
            {
                TempData["OutOfStock"] = "Out";
                TempData["SL"] = checkPro;
                return RedirectToAction(TempData["Route"].ToString());

            }


            if (checkOrder == null)
            {
                var insert = _context.OrderCarts.Add(order);
            }
            else
            {
                int update = order.SL + checkOrder.SL;
                checkOrder.SL = update;
            }
            TempData["Order"] = "sucess";
            _context.SaveChanges();
            HttpContext.Session.SetInt32("CountCart", countCart());
            return RedirectToAction(TempData["Route"].ToString());
        }
        [HttpGet]
        public IActionResult AddOneToCart(String maSp)
        {
            string email = LogCheck();
            if (string.IsNullOrEmpty(email))
            {
                return RedirectToAction("Login");
            }
            var products = from anh in _context.Anhs
                           join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                           where anh.MaSp.Equals(maSp)
                           select new Anh
                           {
                               MaAnh = anh.MaAnh,
                               MaSp = sp.MaSp,
                               MaSpNavigation = sp,
                           };
            var product = products.FirstOrDefault();

            OrderCart order = new OrderCart()
            {
                MaSp = maSp,
                SL = 1,
                MaKm = 0,
                DonGia = product.MaSpNavigation.DonGia.Value,
                TenSP = product.MaSpNavigation.TenSp,
                MaAnh = product.MaAnh,
                email=email
            };
            //check sp in order ?
            var checkOrder = _context.OrderCarts.FirstOrDefault(u => u.MaSp.Equals(order.MaSp)&&u.email.Equals(email));
            //check sl con lai
            var checkPro = _context.KhoSanphams.Where(u => u.MaSp == order.MaSp).Sum(u => u.SoLuong);
            if (TempData["Route"].Equals("Detail"))
            {
                TempData["RouteDetail"] = order.MaSp;
            }
            if (checkPro < order.SL)
            {
                TempData["OutOfStock"] = "Out";
                TempData["SL"] = checkPro;
                return RedirectToAction(TempData["Route"].ToString());

            }


            if (checkOrder == null)
            {
                var insert = _context.OrderCarts.Add(order);
            }
            else
            {
                int update = order.SL + checkOrder.SL;
                checkOrder.SL = update;
            }
            _context.SaveChanges();
            HttpContext.Session.SetInt32("CountCart", countCart());
            return RedirectToAction(TempData["Route"].ToString());
        }
        [HttpPost]
        public IActionResult AddCoupon(String code)
        {
            int MaKm = 0;
            String email = LogCheck();
            if (String.IsNullOrEmpty(email))
            {
                return RedirectToAction("Login");
            }
            try
            {
                MaKm = Convert.ToInt32(code);
            }
            catch (Exception)
            { throw; }

            var order = _context.OrderCarts.Where(u => u.email.Equals(email)).FirstOrDefault();
            if (order == null)
            {
                TempData["AlertOrder"] = "None";
                return RedirectToAction(TempData["Route"].ToString());
            }

            if (MaKm != 0)
            {
                var checkCoupon = _context.Khachhangs.FirstOrDefault(u => u.MaKm == MaKm && u.Email.Equals(email));
                if (checkCoupon != null)
                {

                    order.MaKm = MaKm;
                    _context.SaveChanges();

                    TempData["Coupon"] = "Sucess";
                }
                else
                {
                    TempData["Coupon"] = "ErrorCoupon";
                }
            }
            else
            {
                TempData["Coupon"] = "ErrorCoupon";
            }
            return RedirectToAction(TempData["Route"].ToString());
        }
        [HttpGet]
        public IActionResult RemovefromCart(String MaSp)
        {
            string email = LogCheck();
            var itemRemove = _context.OrderCarts.Where(u => u.email.Equals(email)).FirstOrDefault(u => u.MaSp.Equals(MaSp));
            _context.OrderCarts.Remove(itemRemove);
            _context.SaveChanges();
            HttpContext.Session.SetInt32("CountCart", countCart());
            return RedirectToAction("Cart");
        }
        [HttpPost]
        public IActionResult UpdateCart(List<int> SL,List<String> MaSp)
        {
            string email = LogCheck();
            for(int i=0;i<MaSp.Count();i++)
            {
                var update = _context.OrderCarts.Where(u => u.email.Equals(email)).FirstOrDefault(u => u.MaSp.Equals(MaSp[i]));
                //check sl
                var kho = _context.KhoSanphams.FirstOrDefault(u => u.MaSp.Equals(MaSp[i]));
                if(kho.SoLuong<SL[i])
                {
                    TempData["ErrorUpdate"] = MaSp[i];
                    break;
                }

                update.SL = SL[i];
                _context.SaveChanges();
            }
            return RedirectToAction(TempData["Route"].ToString());
        }

        [HttpPost]
        public IActionResult UpdateUser(Khachhang khachhang)
        {
            String email = LogCheck();
            if (khachhang.Sdt.Count() < 10)
            {
                TempData["ValidPhone"] = "Số điện thoại sai";
                TempData["RemoveReadonly"] = true;
                return RedirectToAction("InfoAccount");
            }

            var updateInfo = _context.Khachhangs.FirstOrDefault(u => u.Email.Equals(email));

            //thay đổi email session
            if (!email.Equals(khachhang.Email))
            {
                HttpContext.Session.SetString("EmailUser", khachhang.Email);
                Response.Cookies.Append("userName", khachhang.Email);
            }
            TempData["RemoveReadonly"] = null;
            updateInfo.TenKh = khachhang.TenKh;
            updateInfo.DiaChi = khachhang.DiaChi;
            updateInfo.Email = khachhang.Email;
            updateInfo.Sdt = khachhang.Sdt;
            HttpContext.Session.SetString("UserName", findNameUser(khachhang.Email));

            _context.SaveChanges();

            return RedirectToAction("InfoAccount");
        }
        public IActionResult ChangePassword()
        {
            string email = LogCheck();
            ViewData["Log"] = email;


            return View();
        }
        public IActionResult RemoveReadonly()
        {
            TempData["RemoveReadonly"] = true;
            return RedirectToAction("InfoAccount");
        }
        [HttpPost]
        public IActionResult ChangePassword(KhachHangValid kh)
        {

            String email = LogCheck();
            ViewData["Log"] = email;
            if (kh.MatKhau.Count() < 6 || kh.MatKhau.Count() > 12)
            {
                ViewData["InValidPass"] = "Độ dài mật khẩu sai";
                return View();
            }
            if (!kh.MatKhau.Equals(kh.reMatKhau))
            {
                ViewData["InValidPass"] = "Nhập lại mật khẩu sai";
                return View();
            }


            var updatePass = _context.Khachhangs.FirstOrDefault(u => u.Email.Equals(email));
            updatePass.MatKhau = kh.MatKhau;
            if (!String.IsNullOrEmpty(Request.Cookies["remember"].ToString()))
            {
                Response.Cookies.Append("userPass", kh.MatKhau);
            }
            _context.SaveChanges();

            return RedirectToAction("InfoAccount");
        }
    }
}