using ALTATest.Core.IRepositories;

namespace ALTATest.Data
{
    public interface IUnitOfWork
    {
        IHocVienRepository HocVienRepository { get; }
        IMonHocRepository MonHocRepository { get; }
        IBangDiemRepository BangDiemRepository { get; }

        void Commit();
        void RollBack();
        Task CommitAsync();
        Task RollBackAsync();
    }
}
