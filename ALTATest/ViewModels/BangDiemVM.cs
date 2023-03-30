using ALTATest.Models;
using System.ComponentModel.DataAnnotations;

namespace ALTATest.ViewModels
{
    public class BangDiemVM
    {
        public int MaHP { get; set; }
        public int MaHV { get; set; }
        public HocVien HocVien { get; set; }
        public int MaMH { get; set; }
        public MonHoc MonHoc { get; set; }
        public float Diem { get; set; }
        public int HeSo { get; set; }
        public int NamHoc { get; set; }
    }
    public class BangDiemVM_Input
    {
        public int MaHV { get; set; }
        public int MaMH { get; set; }
        public float Diem { get; set; }
        public int HeSo { get; set; }
        public int NamHoc { get; set; }
    }
}
