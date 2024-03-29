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

            if (TempData["employee"] != null)
            {

                String id = TempData["employee"].ToString();
                var employee = _context.Nhanviens.FirstOrDefault(u => u.MaNv.Equals(id));
                ViewData["employee"] = employee;

                TempData["employee"] = null;
            }

            ViewData["Log"] = LogCheck();

            try
            {
                var NVmodel = from nv in _context.Nhanviens
                              join cn in _context.Chinhanhs on nv.MaCn equals cn.MaCn
                              where nv.MaCn.Equals(cn.MaCn)
                              select new Nhanvien
                              {
                                  MaNv = nv.MaNv,
                                  MaCn = nv.MaCn,
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
                        //MaCn = nv.MaCn,
                        MaCn = "CN01",
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
        // sửa nhân viên-----------------------------
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
        //load data nv-----------------------------------------------
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

            //ViewData["AlertBill"] = "";
            //if (TempData["AlertBill"] != null)
            //{
            //    ViewData["AlertBill"] = TempData["AlertBill"];
            //    TempData["AlertBill"] = null;
            //}
            TempData["Route"] = "KhachHang";

            if (TempData["employee"] != null)
            {

                String id = TempData["employee"].ToString();
                var employee = _context.Khachhangs.FirstOrDefault(u => u.MaKh.Equals(id));
                ViewData["employee"] = employee;

                TempData["employee"] = null;
            }

            //ViewData["Log"] = LogCheck();

            try
            {
                var KHmodel = from kh in _context.Khachhangs
                              where kh.TrangThai == true
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
                                  TrangThai = kh.TrangThai
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
            //ViewData["Log"] = "";
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
                        Diem = 0,
                        LoaiKh = "New",
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

        // sửa khách hàng-----------------------------
        [HttpPost]
        public IActionResult KhachHang_sua(Khachhang kh)
        {
            ViewData["Log"] = "";
            var update = _context.Khachhangs.FirstOrDefault(u => u.MaKh.Equals(kh.MaKh));
            update.MaKm = kh.MaKm;
            update.TenKh = kh.TenKh;
            update.Email = kh.Email;
            update.Sdt = kh.Sdt;
            update.DiaChi = kh.DiaChi;
            update.MatKhau = kh.MatKhau;
            update.Diem = kh.Diem;
            update.LoaiKh = kh.LoaiKh;
            update.TrangThai = true;
            _context.SaveChanges();
            return RedirectToAction("KhachHang");
        }
        //load data khach hàng-----------------------------------------------
        [HttpGet]
        public IActionResult load_DataKH(string id)
        {
            //tempdata k lưu dc object muốn thì dùng jsonconvert
            TempData["employee"] = id;
            return RedirectToAction("KhachHang");
        }

        [HttpGet]
        public IActionResult KhachHang_xoa(string id)
        {
            ViewData["Log"] = "";
            var update = _context.Khachhangs.FirstOrDefault(u => u.MaKh.Equals(id));
            update.TrangThai = false;
            _context.SaveChanges();
            return RedirectToAction("KhachHang");
        }
        // Hóa đơn
        public IActionResult HoaDon()
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
                var HDmodel = from hd in _context.Hoadons
                              where hd.shipping==null
                              select new Hoadon
                              {
                                  MaHd = hd.MaHd,
                                  MaNv = hd.MaNv,
                                  MaKh = hd.MaKh,
                                  NgayLap = hd.NgayLap,
                                  NgayGiao = hd.NgayGiao,
                                  TenNn = hd.TenNn,
                                  Sdtnn = hd.Sdtnn,
                                  DiaChi = hd.DiaChi,
                                  shippingNote = hd.shippingNote,
                                  shipping = hd.shipping,
                                  TrangThai = hd.TrangThai
                              };
                ViewData["dsHD"] = HDmodel.ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return View();

        }
        // duyệt hóa đơn
        [HttpGet]
        public IActionResult DuyetHoaDon(String id)
        {
            ViewData["Log"] = "";
            var update = _context.Hoadons.FirstOrDefault(u => u.MaHd.Equals(id));
            update.shipping = 2;
            update.NgayGiao = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("HoaDonDaDuyet");
        }
        // hủy hóa đơn
        [HttpGet]
        public IActionResult HuyHoaDon(String id)
        {
            ViewData["Log"] = "";
            var update = _context.Hoadons.FirstOrDefault(u => u.MaHd.Equals(id));
            update.shipping = -1;
            _context.SaveChanges();
            return RedirectToAction("HoaDonDaDuyet");
        }
        // Đã giao
        [HttpGet]
        public IActionResult DaGiaotHoaDon(String id)
        {
            ViewData["Log"] = "";
            var update = _context.Hoadons.FirstOrDefault(u => u.MaHd.Equals(id));
            update.shipping = 0;
            update.NgayGiao = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("HoaDonDaDuyet");
        }

        //hiển thị danh sách Chi nhánh
        public IActionResult ChiNhanh()
        {
            TempData["Route"] = "ChiNhanh";

            //ViewData["AlertBill"] = "";
            //if (TempData["AlertBill"] != null)
            //{
            //    ViewData["AlertBill"] = TempData["AlertBill"];
            //    TempData["AlertBill"] = null;
            //}
            TempData["Route"] = "ChiNhanh";

            if (TempData["employee"] != null)
            {

                String id = TempData["employee"].ToString();
                var employee = _context.Chinhanhs.FirstOrDefault(u => u.MaCn.Equals(id));
                ViewData["employee"] = employee;

                TempData["employee"] = null;
            }

            //ViewData["Log"] = LogCheck();

            try
            {
                var CNmodel = from cn in _context.Chinhanhs
                              select new Chinhanh
                              {
                                  MaCn = cn.MaCn,
                                  Makho = cn.Makho,
                                  TenCn = cn.TenCn,
                                  DiaChi = cn.DiaChi,
                                  Sdt = cn.Sdt,
                                  Email = cn.Email,
                                  TrangThai = cn.TrangThai
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
                    Makho = "KHO01",
                    TenCn = cn.TenCn,
                    DiaChi = cn.DiaChi,
                    Sdt = cn.Sdt,
                    Email = cn.Email,
                    TrangThai = true
                });
                _context.SaveChanges();
                //HttpContext.Session.SetString("EmailUser", kh.Email);
                //HttpContext.Session.SetString("PassWord", kh.MatKhau);
                return RedirectToAction("ChiNhanh");
            }
            return View();
        }

        // sửa chi nhánh-----------------------------
        [HttpPost]
        public IActionResult ChiNhanh_sua(Chinhanh cn)
        {
            ViewData["Log"] = "";
            var update = _context.Chinhanhs.FirstOrDefault(u => u.MaCn.Equals(cn.MaCn));
            update.Makho = cn.Makho;
            update.TenCn = cn.TenCn;
            update.Email = cn.Email;
            update.Sdt = cn.Sdt;
            update.DiaChi = cn.DiaChi;
            update.TrangThai = true;
            _context.SaveChanges();
            return RedirectToAction("ChiNhanh");
        }
        //load data chi nhánh-----------------------------------------------
        [HttpGet]
        public IActionResult load_DataCN(string id)
        {
            //tempdata k lưu dc object muốn thì dùng jsonconvert
            TempData["employee"] = id;
            return RedirectToAction("ChiNhanh");
        }

        [HttpGet]
        public IActionResult ChiNhanh_xoa(string id)
        {
            ViewData["Log"] = "";
            var update = _context.Chinhanhs.FirstOrDefault(u => u.MaCn.Equals(id));
            update.TrangThai = false;
            _context.SaveChanges();
            return RedirectToAction("ChiNhanh");
        }

        // hiển thị danh sách Kho---------------
        public IActionResult Kho()
        {
            TempData["Route"] = "Kho";

            //ViewData["AlertBill"] = "";
            //if (TempData["AlertBill"] != null)
            //{
            //    ViewData["AlertBill"] = TempData["AlertBill"];
            //    TempData["AlertBill"] = null;
            //}

            if (TempData["employee"] != null)
            {

                String id = TempData["employee"].ToString();
                var employee = _context.Khos.FirstOrDefault(u => u.MaKho.Equals(id));
                ViewData["employee"] = employee;

                TempData["employee"] = null;
            }
            //ViewData["Log"] = LogCheck();

            try
            {
                var Kmodel = from k in _context.Khos
                             select new Kho
                             {
                                 MaKho = k.MaKho,
                                 TenKho = k.TenKho,
                                 DiaChi = k.DiaChi,
                                 Sdt = k.Sdt,
                                 Email = k.Email,
                                 TrangThai = k.TrangThai
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
                if (ModelState.IsValid)
                {
                    int lastId = Convert.ToInt32(_context.Khos.OrderBy(u => u.MaKho).LastOrDefault().MaKho.Substring(3));
                    var insert = _context.Khos.Add(new Kho 
                    {
                        MaKho = lastId >= 9 ? "KHO" + (lastId + 1) : "KHO0" + (lastId + 1),
                        TenKho = k.TenKho,
                        DiaChi = k.DiaChi,
                        Sdt = k.Sdt,
                        Email = k.Email,
                        TrangThai = true,
                    });
                    _context.SaveChanges();
                    //HttpContext.Session.SetString("EmailUser", kh.Email);
                    //HttpContext.Session.SetString("PassWord", kh.MatKhau);
                    return RedirectToAction("Kho");
                }
                return View();
            }
            return View();
        }

        // sửa kho-----------------------------
        [HttpPost]
        public IActionResult Kho_sua(Kho k)
        {
            ViewData["Log"] = "";
            var update = _context.Khos.FirstOrDefault(u => u.MaKho.Equals(k.MaKho));
            update.TenKho = k.TenKho;
            update.Email = k.Email;
            update.Sdt = k.Sdt;
            update.DiaChi = k.DiaChi;
            _context.SaveChanges();
            return RedirectToAction("Kho");
        }
        //load data kho-----------------------------------------------
        [HttpGet]
        public IActionResult load_DataKho(string id)
        {
            //tempdata k lưu dc object muốn thì dùng jsonconvert
            TempData["employee"] = id;
            return RedirectToAction("Kho");
        }

        [HttpGet]
        public IActionResult Kho_xoa(string id)
        {
            ViewData["Log"] = "";
            var update = _context.Khos.FirstOrDefault(u => u.MaKho.Equals(id));
            update.TrangThai = false;
            _context.SaveChanges();
            return RedirectToAction("Kho");
        }

        // hiển thị danh sách Khuyến mãi
        public IActionResult KhuyenMai()
        {
            TempData["Route"] = "KhuyenMai";

            //ViewData["AlertBill"] = "";
            //if (TempData["AlertBill"] != null)
            //{
            //    ViewData["AlertBill"] = TempData["AlertBill"];
            //    TempData["AlertBill"] = null;
            //}

            if (TempData["employee"] != null)
            {

                String id = TempData["employee"].ToString();
                int id_int = Int32.Parse(id.ToString());
                var employee = _context.Khuyenmais.FirstOrDefault(u => u.MaKm.Equals(id_int));
                ViewData["employee"] = employee;

                TempData["employee"] = null;
            }
            //ViewData["Log"] = LogCheck();

            try
            {
                var KMmodel = from km in _context.Khuyenmais
                              select new Khuyenmai
                              {
                                  MaKm = km.MaKm,
                                  TenKm = km.TenKm,
                                  MoTa = km.MoTa,
                                  LoaiKm = km.LoaiKm,
                                  NgayBd = km.NgayBd,
                                  NgayKt = km.NgayKt,
                                  TrangThai = km.TrangThai
                              };
                ViewData["dsKhuyenMai"] = KMmodel.ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return View();

        }
        // thêm khuyến mãi
        [HttpPost]
        public IActionResult KhuyenMai(Khuyenmai km)
        {
            ViewData["Log"] = "";
            if (ModelState.IsValid)
            {
                //int lastId = Convert.ToInt32(_context.Khuyenmais.OrderBy(u => u.MaKm).LastOrDefault().MaKm.Substring(0));
                int lastId = Convert.ToInt32(_context.Khuyenmais.OrderBy(u => u.MaKm).LastOrDefault().MaKm);
                var insert = _context.Khuyenmais.Add(new Khuyenmai
                {
                    MaKm = lastId + 1,
                    TenKm = km.TenKm,
                    MoTa = km.MoTa,
                    LoaiKm = km.LoaiKm,
                    NgayBd = km.NgayBd,
                    NgayKt = km.NgayKt,
                    TrangThai = true
                });
                _context.SaveChanges();
                //HttpContext.Session.SetString("EmailUser", kh.Email);
                //HttpContext.Session.SetString("PassWord", kh.MatKhau);
                return RedirectToAction("KhuyenMai");
            }
            return View();
        }

        // sửa khuyen mai-----------------------------
        [HttpPost]
        public IActionResult KhuyenMai_sua(Khuyenmai km)
        {
            ViewData["Log"] = "";
            var update = _context.Khuyenmais.FirstOrDefault(u => u.MaKm.Equals(km.MaKm));
            update.TenKm = km.TenKm;
            update.MoTa = km.MoTa;
            update.LoaiKm = km.LoaiKm;
            update.NgayBd = km.NgayBd;
            update.NgayKt = km.NgayKt;
            update.TrangThai = true;
            _context.SaveChanges();
            return RedirectToAction("KhuyenMai");
        }
        //load data nv-----------------------------------------------
        [HttpGet]
        public IActionResult load_DataKM(int id)
        {
            //tempdata k lưu dc object muốn thì dùng jsonconvert
            TempData["employee"] = id;
            return RedirectToAction("KhuyenMai");
        }

        [HttpGet]
        public IActionResult KhuyenMai_xoa(int id)
        {
            ViewData["Log"] = "";
            var update = _context.Khuyenmais.FirstOrDefault(u => u.MaKm.Equals(id));
            update.TrangThai = false;
            _context.SaveChanges();
            return RedirectToAction("KhuyenMai");
        }

        // HIỂN THỊ danh sách Nha Cung cấp
        public IActionResult NhaCungCap()
        {
            TempData["Route"] = "NhaCungCap";

            //ViewData["AlertBill"] = "";
            //if (TempData["AlertBill"] != null)
            //{
            //    ViewData["AlertBill"] = TempData["AlertBill"];
            //    TempData["AlertBill"] = null;
            //}
            if (TempData["employee"] != null)
            {

                String id = TempData["employee"].ToString();
                var employee = _context.Nhacungcaps.FirstOrDefault(u => u.MaNcc.Equals(id));
                ViewData["employee"] = employee;

                TempData["employee"] = null;
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
                                  Email = cc.Email,
                                  TrangThai = cc.TrangThai
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
                    MaNcc = lastId >= 9 ? "NCC" + (lastId + 1) : "NCC0" + (lastId + 1),
                    TenNcc = cc.TenNcc,
                    DiaChi = cc.DiaChi,
                    Sdt = cc.Sdt,
                    Email = cc.Email,
                    TrangThai = true
                });
                _context.SaveChanges();
                //HttpContext.Session.SetString("EmailUser", kh.Email);
                //HttpContext.Session.SetString("PassWord", kh.MatKhau);
                return RedirectToAction("NhaCungCap");
            }
            return View();
        }

        // sửa nhà cung cấp -----------------------------
        [HttpPost]
        public IActionResult NhaCungCap_sua(Nhacungcap ncc)
        {
            ViewData["Log"] = "";
            var update = _context.Nhacungcaps.FirstOrDefault(u => u.MaNcc.Equals(ncc.MaNcc));
            //update.MaNcc = ncc.MaNcc;
            update.TenNcc = ncc.TenNcc;
            update.Email = ncc.Email;
            update.Sdt = ncc.Sdt;
            update.DiaChi = ncc.DiaChi;
            update.TrangThai = true;
            _context.SaveChanges();
            return RedirectToAction("NhaCungCap");
        }
        //load data nv-----------------------------------------------
        [HttpGet]
        public IActionResult load_DataNCC(string id)
        {
            //tempdata k lưu dc object muốn thì dùng jsonconvert
            TempData["employee"] = id;
            return RedirectToAction("NhaCungCap");
        }

        [HttpGet]
        public IActionResult NhaCungCap_xoa(string id)
        {
            ViewData["Log"] = "";
            var update = _context.Nhacungcaps.FirstOrDefault(u => u.MaNcc.Equals(id));
            update.TrangThai = false;
            _context.SaveChanges();
            return RedirectToAction("NhaCungCap");
        }
        // hiển hị hóa đơn
        public IActionResult HoaDonDaDuyet()
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
                var HDmodel = from hd in _context.Hoadons
                              select new Hoadon
                              {
                                  MaHd = hd.MaHd,
                                  MaNv = hd.MaNv,
                                  MaKh = hd.MaKh,
                                  NgayLap = hd.NgayLap,
                                  NgayGiao = hd.NgayGiao,
                                  TenNn = hd.TenNn,
                                  Sdtnn = hd.Sdtnn,
                                  DiaChi = hd.DiaChi,
                                  shippingNote = hd.shippingNote,
                                  shipping = hd.shipping,
                                  TrangThai = hd.TrangThai
                              };
                ViewData["dsHD"] = HDmodel.ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return View();
        }
        //-----hiện form login
        public IActionResult Admin_Login()
        {
            ViewData["Log"] = "";
            AccountLogin account = new AccountLogin();
            if (!String.IsNullOrEmpty(Request.Cookies["adName"]))
            {
                account.Email = Request.Cookies["adName"].ToString();
                account.MatKhau = !String.IsNullOrEmpty(Request.Cookies["adPass"].ToString()) ? Request.Cookies["adPass"].ToString() : null;
                account.Remember = !String.IsNullOrEmpty(Request.Cookies["remember"].ToString()) ? true : false;
            }
            ViewData["Account"] = account;
            return View();
        }

        //---- Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            //HttpContext.Session.SetInt32("CountCart", countCart());
            return RedirectToAction("Admin_Login");
        }

        // ------- đăng nhập
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Admin_Login(AccountLogin log)
        {
            AccountLogin account = new AccountLogin();
            ViewData["Account"] = account;
            ViewData["Log"] = "";
            if (ModelState.IsValid)
            {
                try
                {

                    var userExist = _context.Nhanviens.Where(u => u.Email.Equals(log.Email)).Count();
                    if (userExist > 0)
                    {
                        var PassCheck = _context.Nhanviens.Where(u => u.Email.Equals(log.Email) && u.MatKhau.Equals(log.MatKhau));
                        if (PassCheck.Count() > 0)
                        {

                            Response.Cookies.Append("adPass", log.MatKhau);
                            Response.Cookies.Append("remember", "");
                            Response.Cookies.Append("adName", log.Email);
                            HttpContext.Session.SetString("EmailAd", log.Email);
                            HttpContext.Session.SetString("PassWordAd", log.MatKhau);
                            HttpContext.Session.SetString("AdName", findNameUser(log.Email));
                            return RedirectToAction("HoaDon");
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

        public String findNameUser(string email)
        {
            var user = _context.Nhanviens.FirstOrDefault(u => u.Email.Equals(email));
            return user.TenNv.Split(" ").Last();
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


        // hiển thị sản phẩm
        public IActionResult SanPham()
        {
            TempData["Route"] = "SanPham";

            if (TempData["employee"] != null)
            {

                String id = TempData["employee"].ToString();
                var employee = _context.Sanphams.FirstOrDefault(u => u.MaSp.Equals(id));
                ViewData["employee"] = employee;

                TempData["employee"] = null;
            }

            ViewData["Log"] = LogCheck();

            try
            {
                var SPmodel = from sp in _context.Sanphams
                                  //join cn in _context.Chinhanhs on nv.MaCn equals cn.MaCn
                                  //where nv.MaCn.Equals(cn.MaCn)
                              select new Sanpham
                              {
                                  MaSp = sp.MaSp,
                                  MaNcc = sp.MaNcc,
                                  MaNv = sp.MaNv,
                                  MaKm = sp.MaKm,
                                  TenSp = sp.TenSp,
                                  LoaiSp = sp.LoaiSp,
                                  ThuongHieu = sp.ThuongHieu,
                                  ChiTietSp = sp.ChiTietSp,
                                  DonGia = sp.DonGia,
                                  DanhGia = sp.DanhGia,
                                  NgaySua = sp.NgaySua,
                                  NgayTao = sp.NgayTao,
                                  TrangThai = sp.TrangThai
                              };

                ViewData["dsSanPham"] = SPmodel.ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return View();
        }
        // Thêm nhân viên
        [HttpPost]
        public IActionResult SanPham(Sanpham sp)
        {
            ViewData["Log"] = "";
            if (ModelState.IsValid)
            {

                int lastId = Convert.ToInt32(_context.Sanphams.OrderBy(u => u.MaSp).LastOrDefault().MaSp.Substring(2));
                var insert = _context.Sanphams.Add(new Sanpham
                {
                    MaSp = lastId >= 9 ? "SP" + (lastId + 1) : "SP0" + (lastId + 1),
                    MaNcc = sp.MaNcc,
                    MaNv = sp.MaNv,
                    MaKm = sp.MaKm,
                    TenSp = sp.TenSp,
                    LoaiSp = sp.LoaiSp,
                    ThuongHieu = sp.ThuongHieu,
                    ChiTietSp = sp.ChiTietSp,
                    DonGia = sp.DonGia,
                    DanhGia = sp.DanhGia,
                    
                    NgayTao = DateTime.Now,
                    TrangThai = true
                });
                _context.SaveChanges();
                //HttpContext.Session.SetString("EmailUser", kh.Email);
                //HttpContext.Session.SetString("PassWord", kh.MatKhau);
                return RedirectToAction("SanPham");
            }
            return RedirectToAction("SanPham");
        }
        // sửa nhân viên-----------------------------
        [HttpPost]
        public IActionResult SanPham_sua(Sanpham sp)
        {
            ViewData["Log"] = "";
            var update = _context.Sanphams.FirstOrDefault(u => u.MaSp.Equals(sp.MaSp));
            update.MaNcc = sp.MaNcc;
            update.MaNv = sp.MaNv;
            update.MaKm = sp.MaKm;
            update.TenSp = sp.TenSp;
            update.LoaiSp = sp.LoaiSp;
            update.ThuongHieu = sp.ThuongHieu;
            update.ChiTietSp = sp.ChiTietSp;
            update.DonGia = sp.DonGia;
            update.DanhGia = sp.DanhGia;
            update.NgaySua = DateTime.Now;
            update.NgayTao = sp.NgayTao;
            update.TrangThai = true;
            _context.SaveChanges();
            return RedirectToAction("SanPham");
        }
        //load data nv-----------------------------------------------
        [HttpGet]
        public IActionResult load_DataSP(string id)
        {
            //tempdata k lưu dc object muốn thì dùng jsonconvert
            TempData["employee"] = id;
            return RedirectToAction("SanPham");
        }

        [HttpGet]
        public IActionResult SanPham_xoa(string id)
        {
            ViewData["Log"] = "";
            var update = _context.Sanphams.FirstOrDefault(u => u.MaSp.Equals(id));
            update.TrangThai = false;
            _context.SaveChanges();
            return RedirectToAction("SanPham");
        }


        // hiển thị phiếu nhập
        public IActionResult PhieuNhap()
        {
            TempData["Route"] = "PhieuNhap";

            if (TempData["employee"] != null)
            {

                String id = TempData["employee"].ToString();
                var employee = _context.Phieunhaps.FirstOrDefault(u => u.MaPn.Equals(id));
                ViewData["employee"] = employee;

                TempData["employee"] = null;
            }

            ViewData["Log"] = LogCheck();

            try
            {
                var NVmodel = from nv in _context.Phieunhaps
                                  //join cn in _context.Chinhanhs on nv.MaCn equals cn.MaCn
                                  //where nv.MaCn.Equals(cn.MaCn)
                              select new Phieunhap
                              {
                                  MaPn = nv.MaPn,
                                  MaNv = nv.MaNv,
                                  MaSp = nv.MaSp,
                                  SoLuong = nv.SoLuong,
                                  DonGia = nv.DonGia,
                                  ThanhTien = nv.ThanhTien,
                                  NgayNhap = nv.NgayNhap,
                                  TrangThai = nv.TrangThai
                              };

                ViewData["dsPhieuNhap"] = NVmodel.ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return View();
        }
        // Thêm nhân viên
        [HttpPost]
        public IActionResult PhieuNhap(Phieunhap nv)
        {
            ViewData["Log"] = "";
            if (ModelState.IsValid)
            {

                int lastId = Convert.ToInt32(_context.Phieunhaps.OrderBy(u => u.MaPn).LastOrDefault().MaPn.Substring(2));
                var insert = _context.Phieunhaps.Add(new Phieunhap
                {
                    MaPn = lastId >= 9 ? "PN" + (lastId + 1) : "PN0" + (lastId + 1),
                    //MaCn = nv.MaCn,
                    MaNv = nv.MaNv,
                    MaSp = nv.MaSp,
                    SoLuong = nv.SoLuong,
                    DonGia = nv.DonGia,
                    ThanhTien = nv.ThanhTien,
                    NgayNhap = DateTime.Now,
                    TrangThai = true
                });
                _context.SaveChanges();
                //HttpContext.Session.SetString("EmailUser", kh.Email);
                //HttpContext.Session.SetString("PassWord", kh.MatKhau);
                return RedirectToAction("PhieuNhap");

            }
            return RedirectToAction("PhieuNhap");
        }
        // sửa nhân viên-----------------------------
        [HttpPost]
        public IActionResult PhieuNhap_sua(Phieunhap nv)
        {
            ViewData["Log"] = "";
            var update = _context.Phieunhaps.FirstOrDefault(u => u.MaPn.Equals(nv.MaPn));
            update.MaNv = nv.MaNv;
            update.MaSp = nv.MaSp;
            update.SoLuong = nv.SoLuong;
            update.DonGia = nv.DonGia;
            update.ThanhTien = nv.ThanhTien;
            update.NgayNhap = DateTime.Now;

            update.TrangThai = true;
            _context.SaveChanges();
            return RedirectToAction("PhieuNhap");
        }
        //load data nv-----------------------------------------------
        [HttpGet]
        public IActionResult load_DataPN(string id)
        {
            //tempdata k lưu dc object muốn thì dùng jsonconvert
            TempData["employee"] = id;
            return RedirectToAction("PhieuNhap");
        }

        [HttpGet]
        public IActionResult PhieuNhap_xoa(string id)
        {
            ViewData["Log"] = "";
            var update = _context.Phieunhaps.FirstOrDefault(u => u.MaPn.Equals(id));
            update.TrangThai = false;
            _context.SaveChanges();
            return RedirectToAction("PhieuNhap");
        }

    }
}
