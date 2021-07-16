using System;
using System.Collections.Generic;

#nullable disable

namespace WebLapTop.Models
{
    public partial class Khuyenmai
    {
        public Khuyenmai()
        {
            Khachhangs = new HashSet<Khachhang>();
            Sanphams = new HashSet<Sanpham>();
        }

        public int MaKm { get; set; }
        public string TenKm { get; set; }
        public string MoTa { get; set; }
        public int? LoaiKm { get; set; }
        public DateTime? NgayBd { get; set; }
        public DateTime? NgayKt { get; set; }
        public bool? TrangThai { get; set; }
        public virtual ICollection<Khachhang> Khachhangs { get; set; }
        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
