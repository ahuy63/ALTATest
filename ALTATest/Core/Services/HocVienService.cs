using ALTATest.Core.IServices;
using ALTATest.Data;
using ALTATest.Models;

namespace ALTATest.Core.Services
{
    public class HocVienService : IHocVienService
    {
        public IUnitOfWork _unitOfWork;
        public HocVienService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> Add(HocVien input)
        {
            try
            {
                await _unitOfWork.HocVienRepository.Add(input);
                await _unitOfWork.CommitAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public async Task<IEnumerable<HocVien>> GetAll()
        {
            return await _unitOfWork.HocVienRepository.GetAllAsync();
        }

        public async Task<HocVien> GetById(int id)
        {
            return await _unitOfWork.HocVienRepository.GetById(id);
        }

    }
}
