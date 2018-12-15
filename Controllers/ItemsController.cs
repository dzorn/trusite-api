using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TruSite.Api.Domain.Models;
using TruSite.Api.Core.Abstractions.Services;

namespace TruSite.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ItemsController : ControllerBase
	{
		private readonly IItemService itemService;

		public ItemsController(IItemService itemService) : base()
		{
			this.itemService = itemService;
		}

		// GET api/items
		[HttpGet]
		[ProducesResponseType(typeof(IList<ItemModel>), 200)]
		[ProducesResponseType(400)]
		public async Task<IActionResult> GetAsync([FromQuery]bool? active = null)
		{
			try
			{
				return Ok(await itemService.GetItemsAsync(active));
			}
			catch(Exception ex)
			{
				return BadRequest(ex);
			}
		}

		//// GET api/values/5
		//[HttpGet("{id}")]
		//[ProducesResponseType(typeof(ItemModel), 200)]
		//[ProducesResponseType(400)]
		//public async Task<IActionResult> GetAsync(Guid id)
		//{
		//	try
		//	{
		//		return Ok(await itemService.GetItemByIdAsync(id));
		//	}
		//	catch (Exception ex)
		//	{
		//		return BadRequest(ex);
		//	}
		//}

		//// POST api/values
		//[HttpPost]
		//[ProducesResponseType(typeof(ItemModel), 201)]
		//[ProducesResponseType(400)]
		//[ProducesResponseType(500)]
		//public async Task<IActionResult> PostAsync([FromBody]ItemModel model)
		//{
		//	return ModelState.IsValid ? Created(string.Empty, await itemService.CreateItemAsync(model)) : (IActionResult)BadRequest(ModelState);
		//}

		//// PUT api/values/5
		//[HttpPut]
		//[ProducesResponseType(typeof(ItemModel), 200)]
		//[ProducesResponseType(400)]
		//public async Task<IActionResult> PutAsync([FromBody]ItemModel model)
		//{
		//	return ModelState.IsValid ? Ok(await itemService.UpdateItemAsync(model)) : (IActionResult)BadRequest(ModelState);
		//}

		//[HttpPatch]
		//[ProducesResponseType(typeof(ItemModel), 200)]
		//[ProducesResponseType(400)]
		//public async Task<IActionResult> PatchAsync([FromQuery]Guid id, [FromBody]IDictionary<string, object> property_Values)
		//{
		//	try
		//	{
		//		return (await itemService.UpdateItemAsync(id, property_Values));
		//	}
		//	catch (Exception ex)
		//	{
		//		return BadRequest(ex)
		//	}
		//}

		//// DELETE api/values/5
		//[HttpDelete("{id}")]
		//[ProducesResponseType(typeof(ItemModel), 200)]
		//[ProducesResponseType(400)]
		//public async Task<IActionResult> DeleteAsync(Guid id)
		//{
		//		await itemService.DeleteItemAsync(id);
		//		return Ok();
		//}

	}
}
