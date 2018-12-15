using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TruSite.Api.Core.Abstractions.Data.Repositories;
using TruSite.Api.Data.Extensions;
using TruSite.Api.Domain.Entities;
using TruSite.Api.Domain.JoinModels;

namespace TruSite.Api.Data
{
	public class ItemRepository : IItemRepository
	{
		private readonly TruSiteContext context;

		public ItemRepository(TruSiteContext context)
		{
			this.context = context;
		}

		public async Task<IList<ItemJoinModel>> GetItemsAsync(bool? active = null)
		{
			var filter = this.ActiveItemFilter(active);

			return await context.Items
				.Join(context.ItemDetails, i => i.Id, d => d.ItemId,
					(i, d) => new ItemJoinModel { Item = i, ItemDetail = d })
				.Where(j => filter(j))
				.GroupBy(i => i.ItemDetail.ItemId)
				.Select(g => g.OrderByDescending(i => i.ItemDetail.BeginDate)
					.ThenBy(i => i.ItemDetail.EndDate ?? DateTime.MaxValue)
					.First())
				.ToListAsync();
		}
	}
}
