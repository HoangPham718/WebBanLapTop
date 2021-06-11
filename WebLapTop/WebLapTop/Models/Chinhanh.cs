using System;
using System.Collections.Generic;

#nullable disable

namespace WebLapTop.Models
{
    public partial class Chinhanh
    {
        public Chinhanh()
        {
            Nhanviens = new HashSet<Nhanvien>();
        }

        public string MaCn { get; set; }
        public string Makho { get; set; }
        public string TenCn { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public bool? TrangThai { get; set; }

        public virtual Kho MakhoNavigation { get; set; }
        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
    }
}
