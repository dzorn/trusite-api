using System;
using TruSite.Api.Domain.Entities.Abstractions;

namespace TruSite.Api.Domain.Entities
{
	public class Item : IEntity
	{
		public Guid Id { get; set; }
		public bool Active { get; set; }
	}
}