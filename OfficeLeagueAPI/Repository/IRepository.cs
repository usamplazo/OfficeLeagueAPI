using Microsoft.AspNetCore.Mvc;

namespace OfficeLeagueAPI.Repository
{
    public interface IRepository<T> where T : class
    {
        public Task<ActionResult<IEnumerable<T>>> Get();
        public Task<T?> GetById(int id);
        public Task<ActionResult<T>> Create(T entity);
        public Task<ActionResult<T>> Update(int id, T entity);
        public Task<ActionResult<T>> Delete(int id);
    }
}
