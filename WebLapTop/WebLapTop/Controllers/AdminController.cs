using WebLapTop.Models;
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
    public class AdminController : Controller
    {

        private readonly WebLapTopContext _context;
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger, WebLapTopContext context)
        {
            _logger = logger;
            this._context = context;
        }

        // hiển thị nhân viên
        public IActionResult NhanVien()
        {
            TempData["Route"] = "NhanVien";

            if(TempData["employee"] !=null)
            {

                String id= TempData["employee"].ToString();
                var employee = _context.Nhanviens.FirstOrDefault(u => u.MaNv.Equals(id));
                ViewData["employee"] = employee;

                TempData["employee"] = null;
            }

            //ViewData["Log"] = LogCheck();

            try
            {
                var NVmodel = from nv in _context.Nhanviens
                              join cn in _context.Chinhanhs
                              on nv.MaCn equals cn.MaCn
                              where nv.TrangThai==true
                              select new Nhanvien
                              {
                                  MaNv = nv.MaNv,
                                  //MaCN=cn.MaCn,
                                  TenNv = nv.TenNv,
                                  Email = nv.Email,
                                  Sdt = nv.Sdt,
                                  DiaChi = nv.DiaChi,
                                  MatKhau = nv.MatKhau,
                                  ChucVu = nv.ChucVu,
                                  Quyen = nv.Quyen,
                                  TrangThai = nv.TrangThai
                              };
                ViewData["dsNhanVien"] = NVmodel.ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return View();
        }
        // Thêm nhân viên
        [HttpPost]
        public IActionResult NhanVien(Nhanvien nv)
        {
            ViewData["Log"] = "";
            if (ModelState.IsValid)
            {
                var emailExist = _context.Nhanviens.FirstOrDefault(u => u.Email.Equals(nv.Email));
                if (emailExist == null)
                {
                    int lastId = Convert.ToInt32(_context.Nhanviens.OrderBy(u => u.MaNv).LastOrDefault().MaNv.Substring(2));
                    var insert = _context.Nhanviens.Add(new Nhanvien
                    {
                        MaNv = lastId >= 9 ? "NV" + (lastId + 1) : "NV0" + (lastId + 1),
                        MaCn = nv.MaCn,
                        TenNv = nv.TenNv,
                        Email = nv.Email,
                        Sdt = nv.Sdt,
                        DiaChi = nv.DiaChi,
                        MatKhau = nv.MatKhau,
                        ChucVu = nv.ChucVu,
                        Quyen = nv.Quyen,
                        TrangThai = true
                    });
                    _context.SaveChanges();
                    //HttpContext.Session.SetString("EmailUser", kh.Email);
                    //HttpContext.Session.SetString("PassWord", kh.MatKhau);
                    return RedirectToAction("NhanVien");
                }
                else
                {
                    ModelState.AddModelError("Email", "Email đã tồn tại");
                }
            }
            return RedirectToAction("NhanVien");
        }
        // sửa nhân viên
        [HttpPost]
        public IActionResult NhanVien_sua(Nhanvien nv)
        {
             ViewData["Log"] = "";
                    var update = _context.Nhanviens.FirstOrDefault(u => u.MaNv.Equals(nv.MaNv));
                    update.MaCn = nv.MaCn;
                    update.TenNv = nv.TenNv;
                    update.Email = nv.Email;
                    update.Sdt = nv.Sdt;
                    update.DiaChi = nv.DiaChi;
                    update.MatKhau = nv.MatKhau;
                    update.ChucVu = nv.ChucVu;
                    update.Quyen = nv.Quyen;
                    update.TrangThai = true;
                    _context.SaveChanges();
            return RedirectToAction("NhanVien");
        }
        //load data nv
        [HttpGet]
        public IActionResult load_DataNV(string id)
        {
            //tempdata k lưu dc object muốn thì dùng jsonconvert
            TempData["employee"] = id;
            return RedirectToAction("NhanVien");
        }
        [HttpGet]
        public IActionResult NhanVien_xoa(string id)
        {
            ViewData["Log"] = "";
            var update = _context.Nhanviens.FirstOrDefault(u => u.MaNv.Equals(id));
            update.TrangThai = false;
            _context.SaveChanges();
            return RedirectToAction("NhanVien");
        }
        // hiển thị khách hàng
        public IActionResult KhachHang()
        {
            TempData["Route"] = "Index";

            ViewData["AlertBill"] = "";
            if (TempData["AlertBill"] != null)
            {
                ViewData["AlertBill"] = TempData["AlertBill"];
                TempData["AlertBill"] = null;
            }
            //ViewData["Log"] = LogCheck();

            try
            {
                var KHmodel = from kh in _context.Khachhangs                                  
                              select new Khachhang
                              {
                                  MaKh = kh.MaKh,
                                  MaKm = kh.MaKm,
                                  TenKh = kh.TenKh,
                                  Email = kh.Email,
                                  Sdt = kh.Sdt,
                                  DiaChi = kh.DiaChi,
                                  MatKhau = kh.MatKhau,
                                  Diem = kh.Diem,
                                  LoaiKh = kh.LoaiKh,
                                  TrangThai=kh.TrangThai
                              };
                ViewData["dsKhachHang"] = KHmodel.ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return View();

        }
        // thêm khách hàng
        [HttpPost]
        public IActionResult KhachHang(Khachhang kh)
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
                        MaKh = lastId >= 9 ? "KH" + (lastId + 1) : "KH0" + (lastId + 1),
                        MaKm = 1,
                        TenKh = kh.TenKh,
                        Email = kh.Email,
                        Sdt = kh.Sdt,
                        DiaChi = kh.DiaChi,
                        MatKhau = kh.MatKhau,  
                        Diem=0,
                        LoaiKh="New",
                        TrangThai = true
                    });
                    _context.SaveChanges();
                    //HttpContext.Session.SetString("EmailUser", kh.Email);
                    //HttpContext.Session.SetString("PassWord", kh.MatKhau);
                    return RedirectToAction("KhachHang");
                }
                else
                {
                    ModelState.AddModelError("Email", "Email đã tồn tại");
                }
            }
            return View();
        }
        // Hóa đơn
        public IActionResult HoaDon()
        {
            return View();

        }

        //hiển thị danh sách Chi nhánh
        public IActionResult ChiNhanh()
        {
            TempData["Route"] = "Index";

            ViewData["AlertBill"] = "";
            if (TempData["AlertBill"] != null)
            {
                ViewData["AlertBill"] = TempData["AlertBill"];
                TempData["AlertBill"] = null;
            }
            //ViewData["Log"] = LogCheck();

            try
            {
                var CNmodel = from cn in _context.Chinhanhs
                             select new Chinhanh
                             {
                                 MaCn =cn.MaCn,
                                 Makho = cn.Makho,
                                 TenCn=cn.TenCn,
                                 DiaChi = cn.DiaChi,
                                 Sdt = cn.Sdt,
                                 Email = cn.Email,
                                 TrangThai=cn.TrangThai
                             };
                ViewData["dsCN"] = CNmodel.ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return View();

        }
        // Thêm chi nhanh
        [HttpPost]
        public IActionResult ChiNhanh(Chinhanh cn)
        {
            ViewData["Log"] = "";
            if (ModelState.IsValid)
            {
                int lastId = Convert.ToInt32(_context.Chinhanhs.OrderBy(u => u.MaCn).LastOrDefault().MaCn.Substring(2));
                var insert = _context.Chinhanhs.Add(new Chinhanh
                {
                    MaCn = lastId >= 9 ? "CN" + (lastId + 1) : "CN0" + (lastId + 1),
                    Makho= "KHO01",
                    TenCn = cn.TenCn,
                    DiaChi = cn.DiaChi,
                    Sdt = cn.Sdt,
                    Email = cn.Email,
                    TrangThai=cn.TrangThai
                });
                _context.SaveChanges();
                //HttpContext.Session.SetString("EmailUser", kh.Email);
                //HttpContext.Session.SetString("PassWord", kh.MatKhau);
                return RedirectToAction("ChiNhanh");
            }
            return View();
        }


        // hiển thị danh sách Kho---------------
        public IActionResult Kho()
        {
            TempData["Route"] = "Index";

            ViewData["AlertBill"] = "";
            if (TempData["AlertBill"] != null)
            {
                ViewData["AlertBill"] = TempData["AlertBill"];
                TempData["AlertBill"] = null;
            }
            //ViewData["Log"] = LogCheck();

            try
            {
                var Kmodel = from k in _context.Khos                                                                                   
                             select new Kho
                              {
                                  MaKho=k.MaKho,
                                  TenKho=k.TenKho,
                                  DiaChi=k.DiaChi,
                                  Sdt=k.Sdt,
                                  Email=k.Email
                              };
                ViewData["dsKho"] = Kmodel.ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return View();

        }

        // Thêm danh sách kho --------------------------
        [HttpPost]
        public IActionResult Kho(Kho k)
        {
            ViewData["Log"] = "";
            if (ModelState.IsValid)
            {
                    int lastId = Convert.ToInt32(_context.Khos.OrderBy(u => u.MaKho).LastOrDefault().MaKho.Substring(3));
                    var insert = _context.Khos.Add(new Kho
                    {
                        MaKho = lastId >= 9 ? "KHO" + (lastId + 1) : "KHO0" + (lastId + 1),
                        TenKho=k.TenKho,
                        DiaChi=k.DiaChi,
                        Sdt=k.Sdt,
                        Email=k.Email
                    });
                    _context.SaveChanges();
                    //HttpContext.Session.SetString("EmailUser", kh.Email);
                    //HttpContext.Session.SetString("PassWord", kh.MatKhau);
                    return RedirectToAction("Kho");             
            }
            return View();
        }

        // Khuyến mãi
        public IActionResult KhuyenMai()
        {
            return View();

        }

        // HIỂN THỊ danh sách Nha Cung cấp
        public IActionResult NhaCungCap()
        {
            TempData["Route"] = "Index";

            ViewData["AlertBill"] = "";
            if (TempData["AlertBill"] != null)
            {
                ViewData["AlertBill"] = TempData["AlertBill"];
                TempData["AlertBill"] = null;
            }
            //ViewData["Log"] = LogCheck();

            try
            {
                var CCmodel = from cc in _context.Nhacungcaps
                             select new Nhacungcap
                             {
                                 MaNcc = cc.MaNcc,
                                 TenNcc = cc.TenNcc,
                                 DiaChi = cc.DiaChi,
                                 Sdt = cc.Sdt,
                                 Email = cc.Email
                             };
                ViewData["dsNCC"] = CCmodel.ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return View();
        }
        // thêm ds nhà cung cấp
        [HttpPost]
        public IActionResult NhaCungCap(Nhacungcap cc)
        {
            ViewData["Log"] = "";
            if (ModelState.IsValid)
            {
                int lastId = Convert.ToInt32(_context.Nhacungcaps.OrderBy(u => u.MaNcc).LastOrDefault().MaNcc.Substring(3));
                var insert = _context.Nhacungcaps.Add(new Nhacungcap
                {
                    MaNcc= lastId >= 9 ? "NCC" + (lastId + 1) : "NCC0" + (lastId + 1),
                    TenNcc = cc.TenNcc,
                    DiaChi = cc.DiaChi,
                    Sdt = cc.Sdt,
                    Email = cc.Email
                });
                _context.SaveChanges();
                //HttpContext.Session.SetString("EmailUser", kh.Email);
                //HttpContext.Session.SetString("PassWord", kh.MatKhau);
                return RedirectToAction("NhaCungCap");
            }
            return View();
        }
    }
}
