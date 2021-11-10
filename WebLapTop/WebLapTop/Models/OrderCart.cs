using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebLapTop.Models
{
    [Table("OrderCart")]
    public partial class OrderCart
    {
        public int Id { get; set; }
        public String MaSp { get; set; }
        public String MaAnh { get; set; }
        public String TenSP { get; set; }
        public String email { get; set; }
        public double DonGia { get; set; }
        public int SL { get; set; }
        public int MaKm { get; set; }
    }
}
