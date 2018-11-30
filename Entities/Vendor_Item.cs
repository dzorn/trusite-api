using System;
using TruSite.Api.Entities.Abstractions;

namespace TruSite.Api.Entities
{
	public class Vendor_Item : IEntity
	{
		public Guid Id { get; set; }
		public Guid VendorId { get; set; }
		public Guid ItemId { get; set; }
		public string VendorItemNumber { get; set; }
	}
}