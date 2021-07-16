using System;
using System.Collections.Generic;

#nullable disable

namespace WebLapTop.Models
{
    public partial class Nhacungcap
    {
        public Nhacungcap()
        {
            Sanphams = new HashSet<Sanpham>();
        }

        public string MaNcc { get; set; }
        public string TenNcc { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public bool? TrangThai { get; set; }
        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
