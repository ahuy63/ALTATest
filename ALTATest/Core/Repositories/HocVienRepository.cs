using ALTATest.Core.IRepositories;
using ALTATest.Data;
using ALTATest.Models;

namespace ALTATest.Core.Repositories
{
    public class HocVienRepository : GenericRepository<HocVien>, IHocVienRepository
    {
        public HocVienRepository(SchoolDbContext context) : base(context)
        {
        }
    }
}
