using System;
using TruSite.Api.Entities.Abstractions;

namespace TruSite.Api.Entities
{
	public class InvoiceDetail : IEntity
	{
		public Guid Id { get; set; }
		public int Quantity { get; set; }
		public decimal UnitPrice { get; set; }
		public Guid ItemDetailId { get; set; }
		public Guid ItemPriceId { get; set; }
		public Guid InvoiceId { get; set; }
	}
}