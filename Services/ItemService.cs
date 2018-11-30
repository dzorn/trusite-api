using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TruSite.Api.Data.Abstractions;
using TruSite.Api.Entities;
using TruSite.Api.Models;
using TruSite.Api.Services.Abstractions;

namespace TruSite.Api.Services
{
	public class ItemService : IItemService
	{
		private readonly IItemRepository _repository;
		private readonly IMapper _mapper;

		public ItemService(IItemRepository repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<IEnumerable<ItemModel>> GetAllItemsAsync()
		{
			var results = await _repository.GetAllAsync();
			return results.Select(r => _mapper.Map<ItemModel>(r));
		}

		public async Task<ItemModel> GetItemByIdAsync(Guid id)
		{
			return _mapper.Map<ItemModel>(await _repository.GetByIdAsync(id));
		}

		public async Task<ItemModel> CreateItemAsync(ItemModel model)
		{
			var data = _mapper.Map<Item>(model);
			await _repository.BeginTransactionAsync();
			try
			{
				await _repository.CreateAsync(data);
				_repository.CommitTransaction();
				return _mapper.Map<ItemModel>(data);
			}
			catch
			{
				_repository.RollbackTransaction();
				throw;
			}
		}

		public async Task<ItemModel> UpdateItemAsync(ItemModel model)
		{
			var data = _mapper.Map<Item>(model);
			await _repository.BeginTransactionAsync();
			try
			{
				await _repository.UpdateAsync(data);
				_repository.CommitTransaction();
				return _mapper.Map<ItemModel>(data);
			}
			catch
			{
				_repository.RollbackTransaction();
				throw;
			}
		}

		public async Task DeleteItemAsync(Guid id)
		{
			await _repository.BeginTransactionAsync();
			try
			{
				await _repository.DeleteAsync(id);
				_repository.CommitTransaction();
			}
			catch
			{
				_repository.RollbackTransaction();
				throw;
			}
		}

		public async Task<IEnumerable<NoteModel>> GetItemNotesAsync(Guid itemId)
		{
			var results = await _repository.GetItemNotesAsync(itemId);
			return results.Select(r => _mapper.Map<NoteModel>(r));
		}

	}
}
