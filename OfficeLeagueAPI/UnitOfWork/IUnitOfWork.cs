using Microsoft.EntityFrameworkCore;

namespace OfficeLeagueAPI.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; }
        public Task SaveChangesAsync();
    }
}
