using ALTATest.Models;

namespace ALTATest.Core.IServices
{
    public interface IHocVienService
    {
        Task<IEnumerable<HocVien>> GetAll();
        Task<HocVien> GetById(int id);
        Task<bool> Add(HocVien input);
    }
}
