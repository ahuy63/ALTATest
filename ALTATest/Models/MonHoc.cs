using System.ComponentModel.DataAnnotations;

namespace ALTATest.Models
{
    public class MonHoc
    {
        [Key]
        public int MaMH { get; set; }
        public string TenMH { get; set; }

    }
}
