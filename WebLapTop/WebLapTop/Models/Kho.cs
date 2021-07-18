using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        //[Required(AllowEmptyStrings = false, ErrorMessage = "Không được bỏ trống xã phường")]
        public string DiaChi { get; set; }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "Không được bỏ trống sdt")]
        //[RegularExpression(@"^(\d{10})$", ErrorMessage = "Định dạng số điện thoại sai")]
        public string Sdt { get; set; }

        public string Email { get; set; }
        public bool? TrangThai { get; set; }
        public virtual ICollection<Chinhanh> Chinhanhs { get; set; }
        public virtual ICollection<KhoSanpham> KhoSanphams { get; set; }
    }
}
