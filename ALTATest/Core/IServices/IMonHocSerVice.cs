using ALTATest.Models;

namespace ALTATest.Core.IServices
{
    public interface IMonHocSerVice
    {
        Task<IEnumerable<MonHoc>> GetAll();
        Task<MonHoc> GetById(int id);
        Task<bool> Add(MonHoc input);
    }
}
