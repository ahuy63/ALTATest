using ALTATest.Models;
using Microsoft.EntityFrameworkCore;

namespace ALTATest.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { 
        }
         public DbSet<HocVien> HocVien { get; set; }
         public DbSet<MonHoc> MonHoc { get; set; }
         public DbSet<BangDiem> BangDiem { get; set; }


    }
}
