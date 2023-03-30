using ALTATest.Core.IServices;
using ALTATest.Data;
using ALTATest.Models;

namespace ALTATest.Core.Services
{
    public class MonHocService : IMonHocSerVice
    {
        public IUnitOfWork _unitOfWork;
        public MonHocService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Add(MonHoc input)
        {
            try
            {
                await _unitOfWork.MonHocRepository.Add(input);
                await _unitOfWork.CommitAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public async Task<IEnumerable<MonHoc>> GetAll()
        {
            return await _unitOfWork.MonHocRepository.GetAllAsync();
        }

        public async Task<MonHoc> GetById(int id)
        {
            return await _unitOfWork.MonHocRepository.GetById(id);
        }
    }
}
