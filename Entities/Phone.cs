using System;
using TruSite.Api.Enumerations;
using TruSite.Api.Entities.Abstractions;

namespace TruSite.Api.Entities
{
	public class Phone : IEntity
	{
		public Guid Id { get; set; }
		public long Number { get; set; }
		public int Extension { get; set; }
		public PhoneType PhoneType { get; set; }
		public bool Primary { get; set; }
		public string Name { get; set; }
		public bool Active { get; set; }
		public Guid ContactId { get; set; }
	}
}