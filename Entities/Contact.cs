using System;
using TruSite.Api.Enumerations;
using TruSite.Api.Entities.Abstractions;

namespace TruSite.Api.Entities
{
	public class Contact : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Primary { get; set; }
        public bool Active { get; set; }
        public Guid EntityId { get; set; }
        public EntityType EntityType { get; set; }
    }
}