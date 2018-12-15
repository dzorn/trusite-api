using System.Collections.Generic;
using System.Threading.Tasks;
using TruSite.Api.Domain.Entities;
using TruSite.Api.Domain.JoinModels;

namespace TruSite.Api.Core.Abstractions.Data.Repositories
{
	public interface IItemRepository
	{
		Task<IList<ItemJoinModel>> GetItemsAsync(bool? active = null);
	}
}
