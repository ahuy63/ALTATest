using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ALTATest.Models
{
    public class BangDiem
    {
        [Key]
        public int MaHP { get; set; }
        public int MaHV { get; set; }
        public HocVien HocVien { get; set; }
        public int MaMH { get; set; }
        public MonHoc MonHoc { get; set; }
        public float Diem { get; set; }
        public int HeSo { get; set; }
        public int NamHoc { get; set; }
    }
}
