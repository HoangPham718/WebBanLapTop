using System;
using System.Collections.Generic;

#nullable disable

namespace WebLapTop.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Binhluans = new HashSet<Binhluan>();
            Hoadons = new HashSet<Hoadon>();
        }

        public string MaKh { get; set; }
        public int? MaKm { get; set; }
        public string TenKh { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string MatKhau { get; set; }
        public int? Diem { get; set; }
        public string LoaiKh { get; set; }
        public bool? TrangThai { get; set; }

        public virtual Khuyenmai MaKmNavigation { get; set; }
        public virtual ICollection<Binhluan> Binhluans { get; set; }
        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
