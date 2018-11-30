using System;
using System.Linq;
using System.Threading.Tasks;
using TruSite.Api.Data.Abstractions;
using TruSite.Api.Entities.Abstractions;

namespace TruSite.Api.Data
{
	public class GenericRepository<T> : BaseRepository, IGenericRepository<T>
		where T : class, IEntity
	{
		public GenericRepository(TruSiteContext context) : base(context)
		{ }

		public async Task<IQueryable<T>> GetAllAsync()
		{
			return await Task.Factory.StartNew(() => _context.Set<T>()).ConfigureAwait(false);
		}

		public async Task<T> GetByIdAsync(Guid id)
		{
			return await _context.Set<T>().FindAsync(id);
		}

		public async Task<T> CreateAsync(T entity)
		{
			var result = await _context.Set<T>().AddAsync(entity);
			await _context.SaveChangesAsync();
			return result.Entity;
		}

		public async Task<T> UpdateAsync(T entity)
		{
			var result = _context.Set<T>().Update(entity);
			await _context.SaveChangesAsync();
			return result.Entity;
		}

		public async Task DeleteAsync(Guid id)
		{
			var entity = await GetByIdAsync(id);
			_context.Set<T>().Remove(entity);
			await _context.SaveChangesAsync();
		}

	}
}
