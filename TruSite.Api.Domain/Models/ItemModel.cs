using System;

namespace TruSite.Api.Domain.Models
{
	public class ItemModel
	{
		public Guid Id { get; set; }
		public Guid ItemId { get; set; }
		public bool Active { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int CaseQuantity { get; set; }
		public DateTime BeginDate { get; set; }
		public DateTime? EndDate { get; set; }
	}
}
