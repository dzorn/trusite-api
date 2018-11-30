using System;
using System.Linq;
using System.Threading.Tasks;
using TruSite.Api.Entities;

namespace TruSite.Api.Data.Abstractions
{
	public interface IItemRepository : IGenericRepository<Item>
	{
		Task<IQueryable<Note>> GetItemNotesAsync(Guid itemId);
	}
}
