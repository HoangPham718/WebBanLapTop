using System;
using System.Collections.Generic;

#nullable disable

namespace WebLapTop.Models
{
    public partial class Phieubaohanh
    {
        public string MaBh { get; set; }
        public string MaSp { get; set; }
        public string MaNv { get; set; }
        public DateTime? NgayBd { get; set; }
        public DateTime? NgayKt { get; set; }

        public virtual Nhanvien MaNvNavigation { get; set; }
        public virtual Sanpham MaSpNavigation { get; set; }
    }
}
