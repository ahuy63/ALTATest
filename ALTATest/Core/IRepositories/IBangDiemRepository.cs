using ALTATest.Models;

namespace ALTATest.Core.IRepositories
{
    public interface IBangDiemRepository : IGenericRepository<BangDiem>
    {
        Task<IEnumerable<BangDiem>> GetByCondition(string lop, int nam);
    }
}
