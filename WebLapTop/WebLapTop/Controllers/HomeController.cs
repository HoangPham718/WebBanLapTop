﻿using WebLapTop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using PagedList;
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
            TempData["Route"] = "Index";

            ViewData["AlertBill"] = "";
            if (TempData["AlertBill"] != null)
            {
                ViewData["AlertBill"] = TempData["AlertBill"];
                TempData["AlertBill"] = null;
            }
            ViewData["Log"] = LogCheck();

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

        public IActionResult InfoAccount()
        {
            string email = LogCheck();
            ViewData["Log"] = email;

            if(TempData["RemoveReadonly"]!=null)
            {
                ViewData["RemoveReadonly"] = true;
                TempData["RemoveReadonly"] = null;
            }
            if(TempData["ValidPhone"] !=null)
            {
                ViewData["ValidPhone"] = TempData["ValidPhone"];
                TempData["ValidPhone"] = null;
            }
            var info = _context.Khachhangs.FirstOrDefault(u => u.Email.Equals(email));

            var mota = _context.Khuyenmais.FirstOrDefault(u => u.MaKm == info.MaKm).MoTa;
            if(mota!=null)
                ViewData["mota"] = mota;
            else
                ViewData["mota"] = "Không có khuyến mãi nào!";

            return View(info);
        }
        public IActionResult Cart()
        {
            TempData["Route"] = "Cart";
            String email = LogCheck();
            ViewData["Log"] = email;
            try
            {

                var cart = _context.OrderCarts.ToList();

                String Masp;
                //check order
                if (cart.Count==0)
                {
                    Masp = "SP01";
                }
                else
                {
                    Masp = cart.FirstOrDefault().MaSp;
                }

                //check km, get data khuyenmai
                var checkKM = _context.OrderCarts.FirstOrDefault();
                if (checkKM != null)
                {
                    if (checkKM.MaKm != 0 && !String.IsNullOrEmpty(email))
                    {
                        var khuyenmai = _context.Khuyenmais.FirstOrDefault(u => u.MaKm == checkKM.MaKm);
                        ViewData["Coupon"] = khuyenmai;
                    }
                    else
                    {
                        checkKM.MaKm = 0;
                        _context.SaveChanges();
                        ViewData["Coupon"] = TempData["Coupon"];
                    }
                }
                else
                {
                    ViewData["Coupon"] = TempData["Coupon"];
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
                ViewData["BrandPros"] = BrandPros.Take(8).OrderByDescending(u => u.MaSpNavigation.NgayTao).ToList();

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
                var totalOrder = _context.OrderCarts.Sum(u => u.DonGia * u.SL);


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
                return RedirectToAction("Login");
            }

            //coupon check
            var checkCoupon = _context.OrderCarts.FirstOrDefault();

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

            var cart = _context.OrderCarts.ToList();


            ViewBag.OrderCart = cart;
            ViewData["Total"] = _context.OrderCarts.Sum(u => u.DonGia * u.SL);

            //get data sidebar
            var product = _context.Sanphams.FirstOrDefault(u=>u.MaSp.Equals(checkCoupon.MaSp));
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
            var lastMa = _context.Hoadons.OrderBy(u=>u.MaHd).LastOrDefault().MaHd;
            int lstid = Convert.ToInt32(lastMa.Substring(2));

            Hoadon bill = new Hoadon()
            {
                MaHd= lstid>9? "HD"+(lstid+1): "HD0" + (lstid + 1),
                MaKh =findKH.MaKh,
                NgayLap=DateTime.Now,
                shipping=order.shipping,
                TenNn=order.TenNn,
                DiaChi=order.DiaChi,
                Sdtnn=order.Sdtnn,
                shippingNote=order.shippingNote,
                TrangThai=0
            };
            //tao bill
             _context.Hoadons.Add(bill);

            //get data order
            var listOrder = _context.OrderCarts.ToList();
            int checkKm = listOrder.FirstOrDefault().MaKm;
            int LoaiKm;
            if (checkKm == 0)
            {
                LoaiKm = 0;
            }
            else
            { 
                LoaiKm = _context.Khuyenmais.FirstOrDefault(u => u.MaKm ==checkKm).LoaiKm.Value; 
            }
            

            // add billdetail
            foreach (var item in listOrder)
            {
                Chitiethoadon chitiethoadon = new Chitiethoadon() { 
                    MaHd=bill.MaHd,
                    MaSp=item.MaSp,
                    DonGia=item.DonGia,
                    SoLuong=item.SL,
                    TienKm=LoaiKm*item.DonGia*item.SL/100,
                    ThanhTien= (100-LoaiKm) * item.DonGia * item.SL / 100
                };

                _context.Chitiethoadons.Add(chitiethoadon);

                //remove soluong tu kho
                var kho= _context.KhoSanphams.Where(u => u.MaSp == chitiethoadon.MaSp).Sum(u => u.SoLuong);
                kho = kho - chitiethoadon.SoLuong;

                var updateKho = _context.KhoSanphams.Where(u => u.MaSp == chitiethoadon.MaSp).ToList();

                double total = 0;
                foreach(KhoSanpham sanpham in updateKho)
                {
                    total = total + sanpham.SoLuong.Value;
                    if(total>=chitiethoadon.SoLuong)
                    {
                        sanpham.SoLuong = kho;
                        break;
                    }
                    sanpham.SoLuong = 0;
                }

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
            if (!String.IsNullOrEmpty(Request.Cookies["userName"]))
            {
                account.Email = Request.Cookies["userName"].ToString();
                account.MatKhau = !String.IsNullOrEmpty(Request.Cookies["userPass"].ToString()) ? Request.Cookies["userPass"].ToString():null;
                account.Remember = !String.IsNullOrEmpty(Request.Cookies["remember"].ToString())? true:false ;
            }              
            ViewData["Account"] = account;
            return View();
        }
        public IActionResult Logout()
        {
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
                            else
                            {
                                Response.Cookies.Append("userPass", "");
                                Response.Cookies.Append("remember", "");
                            }
                            Response.Cookies.Append("userName", log.Email);
                            HttpContext.Session.SetString("EmailUser", log.Email);
                            HttpContext.Session.SetString("PassWord", log.MatKhau);
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
                    int lastId =Convert.ToInt32(_context.Khachhangs.OrderBy(u=>u.MaKh).LastOrDefault().MaKh.Substring(2));
                    var insert = _context.Khachhangs.Add( new Khachhang { 
                        MaKh= lastId>9? "KH"+(lastId+1) : "KH0" + (lastId + 1),
                        MaKm=1,
                        TenKh=kh.TenKh,
                        Email=kh.Email,
                        MatKhau=kh.MatKhau,
                        Sdt=kh.Sdt,
                        DiaChi=kh.DiaChi,
                        Diem=0,
                        LoaiKh="New",
                        TrangThai=true
                    });
                    _context.SaveChanges();
                    HttpContext.Session.SetString("EmailUser", kh.Email);
                    HttpContext.Session.SetString("PassWord", kh.MatKhau);
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
            ViewData["Log"] = LogCheck();
            ViewData["Order"] = "";
            //order
            if (TempData["RouteDetail"] != null)
            {
                MaSp = TempData["RouteDetail"].ToString();
                TempData["RouteDetail"] = null;
                ViewData["Order"] = TempData["Order"];
                TempData["Order"] = null;
            }

            //check sl
            if(TempData["OutOfStock"] !=null)
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
            TempData["Route"] = "Cart";
            ViewData["Log"] = LogCheck();
            return View();
        }
        public IActionResult ListProduct(String keyword,int? page)
        {
            //check login 
            ViewData["Log"] = LogCheck();
            string keyquery="";

            //page

            if (page == null||page<1) page = 1;

            int pageSize = 12;
            int pageNumber = page.Value;
            IPagedList<Anh> listPro = null;


            if (String.IsNullOrEmpty(keyword))
            {
                keyquery = "";
            }
            else
            {
                keyquery= keyword.Trim().ToLower();
            }
            try
            {
                
                var products = from anh in _context.Anhs
                               join sp in _context.Sanphams on anh.MaSp equals sp.MaSp
                               where   anh.MaSpNavigation.LoaiSp.Trim().ToLower().Contains(keyquery+"") 
                               || anh.MaSpNavigation.ThuongHieu.Trim().ToLower().Contains(keyquery) ||keyquery.Contains(anh.MaSpNavigation.ThuongHieu.Trim().ToLower()+"")
                               || keyquery.Contains(anh.MaSpNavigation.LoaiSp.Trim().ToLower())
                               select new Anh
                               {
                                   MaAnh = "/img/" + anh.MaAnh + ".png",
                                   MaSp = sp.MaSp,
                                   MaSpNavigation = sp,
                               };
                ViewData["key"] = keyword;
                products = products.OrderByDescending(u => u.MaSpNavigation.NgayTao);
                listPro=products.ToPagedList(pageNumber,pageSize);

                
            }
            catch(Exception)
            {
                throw;
            }

            return View(listPro);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public String LogCheck ()
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
            //check sp in order ?
            var checkOrder = _context.OrderCarts.FirstOrDefault(u=>u.MaSp.Equals(order.MaSp));
            //check sl con lai
            var checkPro = _context.KhoSanphams.Where(u=>u.MaSp==order.MaSp).Sum(u=>u.SoLuong);

            TempData["RouteDetail"] = order.MaSp;

            if (checkPro<order.SL)
            {
                TempData["OutOfStock"] = "Out";
                TempData["SL"] = checkPro;
                return RedirectToAction("Detail", "Home");

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
            return RedirectToAction("Detail","Home");
        }
        [HttpPost]
        public IActionResult AddCoupon(String code)
        {
            int MaKm = 0;
            String email = LogCheck();
            if(String.IsNullOrEmpty(email))
            {
                return RedirectToAction("Login");
            }
            try
            {
                 MaKm = Convert.ToInt32(code);
            }
            catch(Exception)
            { throw; }

            var order = _context.OrderCarts.FirstOrDefault();
            if(order==null)
            {
                return RedirectToAction("Index");
            }

            if (MaKm !=0)
            {
                var checkCoupon = _context.Khachhangs.FirstOrDefault(u => u.MaKm == MaKm && u.Email.Equals(email));
                if(checkCoupon!=null)
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
            var itemRemove = _context.OrderCarts.FirstOrDefault(u => u.MaSp.Equals(MaSp));
            _context.OrderCarts.Remove(itemRemove);
            _context.SaveChanges();
            return RedirectToAction("Cart");
        }

        [HttpPost]
        public IActionResult UpdateUser(Khachhang khachhang)
        {
            String email = LogCheck();
            if(khachhang.Sdt.Count()<10)
            {
                TempData["ValidPhone"] = "Số điện thoại sai";
                TempData["RemoveReadonly"] = true;
                return RedirectToAction("InfoAccount");
            }

            var updateInfo = _context.Khachhangs.FirstOrDefault(u => u.Email.Equals(email));

            //thay đổi email session
            if(!email.Equals(khachhang.Email))
            {
                HttpContext.Session.SetString("EmailUser", khachhang.Email);
                Response.Cookies.Append("userName", khachhang.Email);
            }

            updateInfo.TenKh = khachhang.TenKh;
            updateInfo.DiaChi = khachhang.DiaChi;
            updateInfo.Email = khachhang.Email;
            updateInfo.Sdt = khachhang.Sdt;

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
            if (kh.MatKhau.Count()<6 || kh.MatKhau.Count()>24)
            {
                ViewData["InValidPass"] = "Độ dài mật khẩu sai";
                 return View();
            }
            if(!kh.MatKhau.Equals(kh.reMatKhau))
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