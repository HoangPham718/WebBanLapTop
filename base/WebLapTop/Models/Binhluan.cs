using System;
using System.Collections.Generic;

#nullable disable

namespace WebLapTop.Models
{
    public partial class Binhluan
    {
        public string MaBl { get; set; }
        public string MaSp { get; set; }
        public string MaKh { get; set; }
        public string NoiDung { get; set; }
        public DateTime? Ngay { get; set; }

        public virtual Khachhang MaKhNavigation { get; set; }
        public virtual Sanpham MaSpNavigation { get; set; }
    }
}
