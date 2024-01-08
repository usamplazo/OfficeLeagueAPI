using Microsoft.EntityFrameworkCore;
using OfficeLeagueAPI.Models;

namespace OfficeLeagueAPI.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PremierLeagueDbContext _context;
        private bool _disposed = false;
        
        public UnitOfWork(PremierLeagueDbContext context)
        {
            _context = context;
        }

        #region Overrides

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region Methods

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if(disposing)
                {
                    _context.Dispose();
                }

                _disposed = true;
            }
        }

        #endregion

        #region Properties

        public DbContext Context => _context;

        #endregion
    }
}
