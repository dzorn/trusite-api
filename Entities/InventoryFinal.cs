using System;
using TruSite.Api.Entities.Abstractions;

namespace TruSite.Api.Entities
{
	public class InventoryFinal : IEntity
	{
		public Guid Id { get; set; }
		public Guid ItemId { get; set; }
		public int Quantity { get; set; }
		public DateTime CountDateTime { get; set; }
	}
}