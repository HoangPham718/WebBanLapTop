using System;
using System.Collections.Generic;

#nullable disable

namespace WebLapTop.Models
{
    public partial class KhoSanpham
    {
        public string MaKho { get; set; }
        public string MaSp { get; set; }
        public int? SoLuong { get; set; }

        public virtual Kho MaKhoNavigation { get; set; }
        public virtual Sanpham MaSpNavigation { get; set; }
    }
}
