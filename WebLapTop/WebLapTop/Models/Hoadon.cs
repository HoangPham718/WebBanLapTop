using System;
using System.Collections.Generic;

#nullable disable

namespace WebLapTop.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Chitiethoadons = new HashSet<Chitiethoadon>();
        }

        public string MaHd { get; set; }
        public string MaNv { get; set; }
        public string MaKh { get; set; }
        public DateTime? NgayLap { get; set; }
        public DateTime? NgayGiao { get; set; }
        public string TenNn { get; set; }
        public string Sdtnn { get; set; }
        public string DiaChi { get; set; }
        public int? TrangThai { get; set; }
        public String shippingNote { get; set; }
        public int? shipping { get; set; }

        public virtual Khachhang MaKhNavigation { get; set; }
        public virtual Nhanvien MaNvNavigation { get; set; }
        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }
    }
}
