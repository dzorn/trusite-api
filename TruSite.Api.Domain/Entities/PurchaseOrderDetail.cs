using System;
using TruSite.Api.Domain.Entities.Abstractions;
using TruSite.Api.Domain.Enumerations;

namespace TruSite.Api.Domain.Entities
{
	public class PurchaseOrderDetail : IEntity
	{
		public Guid Id { get; set; }
		public Guid PurchaseOrderId { get; set; }
		public Guid ItemId { get; set; }
		public int Quantity { get; set; }
		public decimal UnitCost { get; set; }
		public PurchaseOrderState State { get; set; }
	}
}