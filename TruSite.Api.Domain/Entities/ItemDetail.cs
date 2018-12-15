using System;
using TruSite.Api.Domain.Entities.Abstractions;

namespace TruSite.Api.Domain.Entities
{
	public class ItemDetail : IEntity
	{
		public Guid Id { get; set; }
		public Guid ItemId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int CaseQuantity { get; set; }
		public DateTime BeginDate { get; set; }
		public DateTime? EndDate { get; set; }
	}
}