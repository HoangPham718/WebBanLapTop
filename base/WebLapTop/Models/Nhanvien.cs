using System;
using System.Collections.Generic;

#nullable disable

namespace WebLapTop.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Hoadons = new HashSet<Hoadon>();
            Phieubaohanhs = new HashSet<Phieubaohanh>();
            Phieunhaps = new HashSet<Phieunhap>();
            Sanphams = new HashSet<Sanpham>();
        }

        public string MaNv { get; set; }
        public string MaCn { get; set; }
        public string TenNv { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string MatKhau { get; set; }
        public string ChucVu { get; set; }
        public string Quyen { get; set; }
        public bool? TrangThai { get; set; }

        public virtual Chinhanh MaCnNavigation { get; set; }
        public virtual ICollection<Hoadon> Hoadons { get; set; }
        public virtual ICollection<Phieubaohanh> Phieubaohanhs { get; set; }
        public virtual ICollection<Phieunhap> Phieunhaps { get; set; }
        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
