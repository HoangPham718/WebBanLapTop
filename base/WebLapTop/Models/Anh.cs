using System;
using System.Collections.Generic;

#nullable disable

namespace WebLapTop.Models
{
    public partial class Anh
    {
        public string MaAnh { get; set; }
        public string MaSp { get; set; }
        public string TenAnh { get; set; }

        public virtual Sanpham MaSpNavigation { get; set; }
    }
}
