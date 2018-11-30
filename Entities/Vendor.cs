using System;
using TruSite.Api.Entities.Abstractions;

namespace TruSite.Api.Entities
{
	public class Vendor : IEntity
	{
		public Guid Id { get; set; }
		public string VendorNumber { get; set; }
		public string Name { get; set; }
	}
}