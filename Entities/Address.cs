using System;
using TruSite.Api.Entities.Abstractions;

namespace TruSite.Api.Entities
{
	public class Address : IEntity
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Attention { get; set; }
		public string StreetOne { get; set; }
		public string StreetTwo { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string PostalCode { get; set; }
		public bool Primary { get; set; }
		public Guid ContactId { get; set; }
	}
}