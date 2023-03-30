using ALTATest.Core.IServices;
using ALTATest.Data;
using ALTATest.Models;

namespace ALTATest.Core.Services
{
    public class BangDIemService : IBangDiemService
    {
        public IUnitOfWork _unitOfWork;
        public BangDIemService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<bool> Add(BangDiem input)
        {
            try
            {
                await _unitOfWork.BangDiemRepository.Add(input);
                await _unitOfWork.CommitAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BangDiem>> GetAll()
        {
            return await _unitOfWork.BangDiemRepository.GetAllAsync();
        }

        public async Task<IEnumerable<BangDiem>> GetByCondition(string lop, int nam)
        {
            return await _unitOfWork.BangDiemRepository.GetByCondition(lop, nam);
        }

        public async Task<BangDiem> GetById(int id)
        {
            return await _unitOfWork.BangDiemRepository.GetById(id);
        }
    }
}
