using ALTATest.Core.IRepositories;
using ALTATest.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ALTATest.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolDbContext _context;
        public IHocVienRepository HocVienRepository { get; private set; }

        public IMonHocRepository MonHocRepository { get; private set; }

        public IBangDiemRepository BangDiemRepository { get; private set; }

        public UnitOfWork(SchoolDbContext context)
        {
            _context = context;
            HocVienRepository = new HocVienRepository(_context);
            MonHocRepository = new MonHocRepository(_context);
            BangDiemRepository = new BangDiemRepository(_context);
        }
        public void Commit() => _context.SaveChanges();
        public async Task CommitAsync() => await _context.SaveChangesAsync();
        public void RollBack() => _context.Dispose();
        public async Task RollBackAsync() => await _context.DisposeAsync();
    }
}
