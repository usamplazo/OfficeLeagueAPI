using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeLeagueAPI.Models;
using OfficeLeagueAPI.UnitOfWork;

namespace OfficeLeagueAPI.Repository
{
    public abstract class RepositoryBase<T> : ControllerBase, IRepository<T> where T : class
    {
        protected readonly PremierLeagueDbContext _context;
        protected DbSet<T> dbSet;
        private readonly IUnitOfWork _unitOfWork;

        protected RepositoryBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            dbSet = _unitOfWork.Context.Set<T>();
        }

        public async Task<ActionResult<T>> Create(T entity)
        {
            dbSet.Add(entity);
            await _unitOfWork.SaveChangesAsync();
            return entity;
        }

        public async Task<ActionResult<T>> Delete(int id)
        {
            //var data = await dbSet.FindAsync(id);

            T? data = await GetById(id);

            if (data is null)
                return NotFound();

            dbSet.Remove(data);
            await _unitOfWork.SaveChangesAsync();

            return NoContent();
        }

        public async Task<ActionResult<IEnumerable<T>>> Get()
        {
            List<T> data = await dbSet.ToListAsync();
            return Ok(data);
        }

        public async Task<ActionResult<T>> Update(int id, T entity)
        {
            //TBD

            //if (id != entity.Id)
            //    return BadRequest();

            //T? existingEntity = await dbSet.FindAsync(id);

            //if (existingEntity is null)
            //    return NotFound();

            //_unitOfWork.Context
            //        .Entry(existingEntity)
            //        .CurrentValues
            //        .SetValues(entity);
            //try
            //{
            //    await _unitOfWork.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException ex)
            //{
            //    throw;
            //}

            return NoContent();
        }

        public async Task<T?> GetById(int id)
        {
            T? existingEntity = await dbSet.FindAsync(id);
            return existingEntity;
        }
    }
}
