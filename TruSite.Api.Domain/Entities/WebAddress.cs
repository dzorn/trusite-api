using System;
using TruSite.Api.Domain.Entities.Abstractions;

namespace TruSite.Api.Domain.Entities
{
	public class WebAddress : IEntity
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string SiteAddress { get; set; }
		public bool Primary { get; set; }
		public bool Active { get; set; }
		public Guid ContactId { get; set; }
	}
}