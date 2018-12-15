using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using TruSite.Api.Core.Abstractions.Data;
using TruSite.Api.Core.Abstractions.Data.Repositories;
using TruSite.Api.Core.Abstractions.Services;
using TruSite.Api.Domain.Models;

namespace TruSite.Api.Services.Data
{
	public class ItemService : IItemService
	{
		private readonly IItemRepository itemRepository;
		private readonly ITransactionManager transactionManager;
		private readonly IMapper mapper;

		public ItemService(IItemRepository itemRepository, ITransactionManager transactionManager, IMapper mapper)
		{
			this.itemRepository = itemRepository;
			this.transactionManager = transactionManager;
			this.mapper = mapper;
		}

		public async Task<IList<ItemModel>> GetItemsAsync(bool? active = null)
		{
			return (await itemRepository.GetItemsAsync(active))
				.Select(i => mapper.Map<ItemModel>(i))
				.ToList();
		}
	}
}
