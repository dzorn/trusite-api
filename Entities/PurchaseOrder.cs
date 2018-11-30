using System;
using TruSite.Api.Enumerations;
using TruSite.Api.Entities.Abstractions;

namespace TruSite.Api.Entities
{
	public class PurchaseOrder : IEntity
	{
		public Guid Id { get; set; }
		public Guid VendorId { get; set; }
		public Guid AddressId { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime ResolveDate { get; set; }
		public PurchaseOrderState State { get; set; }
		public decimal ShippingCost { get; set; }
		public decimal Taxes { get; set; }
		public decimal Fees { get; set; }
	}
}