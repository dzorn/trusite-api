using System;
using TruSite.Api.Entities.Abstractions;

namespace TruSite.Api.Entities
{
	public class Item : IEntity
	{
		public Guid Id { get; set; }
		public bool Active { get; set; }
	}
}