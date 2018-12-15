using System;
using TruSite.Api.Domain.Entities.Abstractions;

namespace TruSite.Api.Domain.Entities
{
	public class Invoice : IEntity
	{
		public Guid Id { get; set; }
		public string InvoiceNumber { get; set; }
		public DateTime InvoiceDate { get; set; }
		public decimal PaidAmount { get; set; }
		public decimal Shipping { get; set; }
		public decimal Taxes { get; set; }
		public decimal Fees { get; set; }
		public bool PaidInFull { get; set; }
		public Guid ClientId { get; set; }
		public Guid DeliveryAddressId { get; set; }
		public Guid BillingAddressId { get; set; }
	}
}