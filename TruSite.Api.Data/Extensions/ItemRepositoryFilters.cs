using System;
using TruSite.Api.Core.Abstractions.Data.Repositories;
using TruSite.Api.Domain.Entities;
using TruSite.Api.Domain.JoinModels;

namespace TruSite.Api.Data.Extensions
{
	public static class ItemRepositoryFilters
	{
		public static Func<ItemJoinModel, bool> ActiveItemFilter(this IItemRepository itemRepository, bool? active = null)
		{
			var currentDetailFilter = new Func<ItemDetail, bool>(d => d.BeginDate <= DateTime.Now &&
				(d.EndDate == null || d.EndDate > DateTime.Now));
			var activeFilter = new Func<Item, bool>(i => i.Active == active.Value);
			return active.HasValue ?
				new Func<ItemJoinModel, bool>(j => activeFilter(j.Item) && currentDetailFilter(j.ItemDetail)) :
				new Func<ItemJoinModel, bool>(j => currentDetailFilter(j.ItemDetail));
		}
	}
}
