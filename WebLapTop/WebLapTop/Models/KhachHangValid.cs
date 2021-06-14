using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebLapTop.Models
{
    public class KhachHangValid
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Không được bỏ trống họ và tên")]
        public string TenKh { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Không được bỏ trống email")]
        [EmailAddress(ErrorMessage = "Định dạng email sai")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Không được bỏ trống sdt")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Định dạng số điện thoại sai")]
        public string Sdt { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Không được bỏ trống địa chỉ")]
        public string DiaChi { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Không được bỏ trống mật khẩu")]
        [StringLength(12, ErrorMessage = "Mật khẩu tối thiểu {2} kí tự và nhiều nhất {1}.", MinimumLength = 6)]
        public string MatKhau { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Không được bỏ trống mật khẩu")]
        [Compare("MatKhau", ErrorMessage = "Mật khẩu nhập lại chưa chính xác")]
        public string reMatKhau { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Phải tick vào đồng ý")]
        public bool Check { get; set; }
    }
}
