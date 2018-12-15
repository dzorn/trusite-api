using System;
using TruSite.Api.Domain.Entities.Abstractions;
using TruSite.Api.Domain.Enumerations;

namespace TruSite.Api.Domain.Entities
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