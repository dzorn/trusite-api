using System;
using TruSite.Api.Enumerations;
using TruSite.Api.Entities.Abstractions;

namespace TruSite.Api.Entities
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