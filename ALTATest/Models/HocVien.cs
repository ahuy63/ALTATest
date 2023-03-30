using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ALTATest.Models
{
    public class HocVien
    {
        [Key]
        public int MaHV { get; set; }
        public string TenHV { get; set; }
        public string Lop { get; set; }
    }
}
