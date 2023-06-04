using UniversityManagement.Core.UnitOfWorks;
using UniversityManagement.Data.Context;

namespace UniversityManagement.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
