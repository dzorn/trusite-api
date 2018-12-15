using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TruSite.Api.Domain.Models;

namespace TruSite.Api.Core.Abstractions.Services
{
	public interface IItemService
	{
		Task<IList<ItemModel>> GetItemsAsync(bool? active = null);
	}
}
