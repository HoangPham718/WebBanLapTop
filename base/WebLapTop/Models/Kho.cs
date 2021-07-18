using System;
using System.Collections.Generic;

#nullable disable

namespace WebLapTop.Models
{
    public partial class Kho
    {
        public Kho()
        {
            Chinhanhs = new HashSet<Chinhanh>();
            KhoSanphams = new HashSet<KhoSanpham>();
        }

        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Chinhanh> Chinhanhs { get; set; }
        public virtual ICollection<KhoSanpham> KhoSanphams { get; set; }
    }
}
