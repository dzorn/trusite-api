using System;
using TruSite.Api.Enumerations;
using TruSite.Api.Entities.Abstractions;

namespace TruSite.Api.Entities
{
	public class InventoryTransaction : IEntity
	{
		public Guid Id { get; set; }
		public DateTime TransactionDateTime { get; set; }
		public int Quantity { get; set; }
		public InventoryTransactionType TransactionType { get; set; }
		public Guid ItemId { get; set; }
	}
}