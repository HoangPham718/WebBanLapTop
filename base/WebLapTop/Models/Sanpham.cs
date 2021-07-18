using System;
using System.Collections.Generic;

#nullable disable

namespace WebLapTop.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Anhs = new HashSet<Anh>();
            Binhluans = new HashSet<Binhluan>();
            Chitiethoadons = new HashSet<Chitiethoadon>();
            KhoSanphams = new HashSet<KhoSanpham>();
            Phieubaohanhs = new HashSet<Phieubaohanh>();
            Phieunhaps = new HashSet<Phieunhap>();
        }

        public string MaSp { get; set; }
        public string MaNcc { get; set; }
        public string MaNv { get; set; }
        public int? MaKm { get; set; }
        public string TenSp { get; set; }
        public string LoaiSp { get; set; }
        public string ThuongHieu { get; set; }
        public string ChiTietSp { get; set; }
        public double? DonGia { get; set; }
        public double? DanhGia { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public bool? TrangThai { get; set; }

        public virtual Khuyenmai MaKmNavigation { get; set; }
        public virtual Nhacungcap MaNccNavigation { get; set; }
        public virtual Nhanvien MaNvNavigation { get; set; }
        public virtual ICollection<Anh> Anhs { get; set; }
        public virtual ICollection<Binhluan> Binhluans { get; set; }
        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }
        public virtual ICollection<KhoSanpham> KhoSanphams { get; set; }
        public virtual ICollection<Phieubaohanh> Phieubaohanhs { get; set; }
        public virtual ICollection<Phieunhap> Phieunhaps { get; set; }
    }
}
