using ALTATest.Models;

namespace ALTATest.Core.IServices
{
    public interface IBangDiemService
    {
        Task<bool> Add(BangDiem input);
        Task<IEnumerable<BangDiem>> GetAll();
        Task<IEnumerable<BangDiem>> GetByCondition(string lop, int nam);
        Task<BangDiem> GetById(int id);
        Task<bool> Delete(int id);

    }
}
