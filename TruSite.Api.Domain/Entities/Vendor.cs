using System;
using TruSite.Api.Domain.Entities.Abstractions;

namespace TruSite.Api.Domain.Entities
{
	public class Vendor : IEntity
	{
		public Guid Id { get; set; }
		public string VendorNumber { get; set; }
		public string Name { get; set; }
	}
}