using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TruSite.Api.Models;
using TruSite.Api.Services.Abstractions;

namespace TruSite.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ItemsController : ControllerBase
	{
		private readonly IItemService _itemService;

		public ItemsController(IItemService itemService) : base()
		{
			_itemService = itemService;
		}

		// GET api/items
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<ItemModel>), 200)]
		[ProducesResponseType(400)]
		public async Task<IActionResult> GetAsync()
		{
			try
			{
				return Ok(await _itemService.GetAllItemsAsync());
			}
			catch(Exception ex)
			{
				return BadRequest(ex);
			}
		}

		// GET api/values/5
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(ItemModel), 200)]
		[ProducesResponseType(400)]
		public async Task<IActionResult> GetAsync(Guid id)
		{
			try
			{
				return Ok(await _itemService.GetItemByIdAsync(id));
			}
			catch (Exception ex)
			{
				return BadRequest(ex);
			}
		}

		// POST api/values
		[HttpPost]
		[ProducesResponseType(typeof(ItemModel), 201)]
		[ProducesResponseType(400)]
		[ProducesResponseType(500)]
		public async Task<IActionResult> PostAsync([FromBody] ItemModel model)
		{
			return ModelState.IsValid ? Created(string.Empty, await _itemService.CreateItemAsync(model)) : (IActionResult)BadRequest(ModelState);
		}

		// PUT api/values/5
		[HttpPut]
		[ProducesResponseType(typeof(ItemModel), 200)]
		[ProducesResponseType(400)]
		public async Task<IActionResult> PutAsync([FromBody] ItemModel model)
		{
			return ModelState.IsValid ? Ok(await _itemService.UpdateItemAsync(model)) : (IActionResult)BadRequest(ModelState);
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		[ProducesResponseType(typeof(ItemModel), 200)]
		[ProducesResponseType(400)]
		public async Task<IActionResult> DeleteAsync(Guid id)
		{
				await _itemService.DeleteItemAsync(id);
				return Ok();
		}

	}
}
