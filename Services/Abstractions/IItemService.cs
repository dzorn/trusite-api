using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TruSite.Api.Models;

namespace TruSite.Api.Services.Abstractions
{
	public interface IItemService
	{
		Task<IEnumerable<ItemModel>> GetAllItemsAsync();
		Task<ItemModel> GetItemByIdAsync(Guid id);
		Task<ItemModel> CreateItemAsync(ItemModel model);
		Task<ItemModel> UpdateItemAsync(ItemModel model);
		Task DeleteItemAsync(Guid id);
		Task<IEnumerable<NoteModel>> GetItemNotesAsync(Guid itemId);
	}
}
