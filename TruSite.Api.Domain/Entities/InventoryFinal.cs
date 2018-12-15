using System;
using TruSite.Api.Domain.Entities.Abstractions;

namespace TruSite.Api.Domain.Entities
{
	public class InventoryFinal : IEntity
	{
		public Guid Id { get; set; }
		public Guid ItemId { get; set; }
		public int Quantity { get; set; }
		public DateTime CountDateTime { get; set; }
	}
}