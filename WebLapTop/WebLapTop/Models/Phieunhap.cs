using System;
using System.Collections.Generic;

#nullable disable

namespace WebLapTop.Models
{
    public partial class Phieunhap
    {
        public string MaPn { get; set; }
        public string MaNv { get; set; }
        public string MaSp { get; set; }
        public int? SoLuong { get; set; }
        public double? DonGia { get; set; }
        public double? ThanhTien { get; set; }
        public DateTime? NgayNhap { get; set; }
        public  bool? TrangThai { get;set;}
        public virtual Nhanvien MaNvNavigation { get; set; }
        public virtual Sanpham MaSpNavigation { get; set; }
    }
}
