using System;
using System.Linq;
using System.Threading.Tasks;
using TruSite.Api.Data.Abstractions;
using TruSite.Api.Entities;
using TruSite.Api.Enumerations;

namespace TruSite.Api.Data
{
	public class ItemRepository : GenericRepository<Item>, IItemRepository
	{

		public ItemRepository(TruSiteContext context) : base(context)
		{ }

		public async Task<IQueryable<Note>> GetItemNotesAsync(Guid itemId)
		{
			return await Task.Factory.StartNew(() =>
				_context.Set<Note>()
					.Where(n => n.ObjectType == ObjectType.Item && n.ObjectId == itemId))
				.ConfigureAwait(false);
		}
	}
}
