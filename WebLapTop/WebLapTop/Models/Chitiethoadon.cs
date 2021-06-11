using System;
using System.Collections.Generic;

#nullable disable

namespace WebLapTop.Models
{
    public partial class Chitiethoadon
    {
        public string MaHd { get; set; }
        public string MaSp { get; set; }
        public int? SoLuong { get; set; }
        public double? DonGia { get; set; }
        public double? TienKm { get; set; }
        public double? ThanhTien { get; set; }

        public virtual Hoadon MaHdNavigation { get; set; }
        public virtual Sanpham MaSpNavigation { get; set; }
    }
}
