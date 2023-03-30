using ALTATest.Core.IRepositories;
using ALTATest.Data;
using ALTATest.Models;
using Microsoft.EntityFrameworkCore;

namespace ALTATest.Core.Repositories
{
    public class BangDiemRepository : GenericRepository<BangDiem>, IBangDiemRepository
    {
        public BangDiemRepository(SchoolDbContext context) : base(context)
        {
        }
        public override async Task<IEnumerable<BangDiem>> GetAllAsync()
        {
            return await _dbSet.Include(x => x.MonHoc).Include(x => x.HocVien).ToListAsync();
        }
        public async Task<IEnumerable<BangDiem>> GetByCondition(string lop, int nam)
        {
            return await _dbSet.Include(x => x.HocVien).Where(x => x.HocVien.Lop == lop).Where(x => x.NamHoc == nam).ToListAsync();
        }
    }
}
