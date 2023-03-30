using ALTATest.Core.IRepositories;
using ALTATest.Data;
using ALTATest.Models;

namespace ALTATest.Core.Repositories
{
    public class MonHocRepository : GenericRepository<MonHoc>, IMonHocRepository
    {
        public MonHocRepository(SchoolDbContext context) : base(context)
        {
        }
    }
}
