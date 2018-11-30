using System;
using TruSite.Api.Enumerations;
using TruSite.Api.Entities.Abstractions;

namespace TruSite.Api.Entities
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