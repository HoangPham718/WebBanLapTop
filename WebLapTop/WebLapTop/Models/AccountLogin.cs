using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebLapTop.Models
{
    public class AccountLogin
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Không được bỏ trống email")]
        [EmailAddress(ErrorMessage = "Định dạng email sai")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Không được bỏ trống mật khẩu")]
        public string MatKhau { get; set; }

        public bool Remember { get; set; }
    }
}
