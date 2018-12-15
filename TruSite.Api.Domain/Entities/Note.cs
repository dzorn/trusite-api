using System;
using TruSite.Api.Domain.Entities.Abstractions;
using TruSite.Api.Domain.Enumerations;

namespace TruSite.Api.Domain.Entities
{
	public class Note : IEntity
	{
		public Guid Id { get; set; }
		public DateTime CreatedDateTime { get; set; }
		public bool Private { get; set; }
		public string Text { get; set; }
		public Guid ObjectId { get; set; }
		public ObjectType ObjectType { get; set; }
	}
}