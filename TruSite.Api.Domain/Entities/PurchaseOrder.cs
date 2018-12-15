using System;
using TruSite.Api.Domain.Entities.Abstractions;
using TruSite.Api.Domain.Enumerations;

namespace TruSite.Api.Domain.Entities
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