using System;
using System.Linq;
using System.Threading.Tasks;
using TruSite.Api.Entities.Abstractions;

namespace TruSite.Api.Data.Abstractions
{
	public interface IGenericRepository<T> : IBaseRepository
		where T : class, IEntity
	{
		Task<IQueryable<T>> GetAllAsync();
		Task<T> GetByIdAsync(Guid id);
		Task<T> CreateAsync(T entity);
		Task<T> UpdateAsync(T entity);
		Task DeleteAsync(Guid id);
	}
}
