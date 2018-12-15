using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TruSite.Api.Core.Abstractions.Data;
using TruSite.Api.Domain.Entities;

namespace TruSite.Api.Data
{
	public class TruSiteContext : DbContext
	{
		public TruSiteContext(DbContextOptions<TruSiteContext> options) : base(options)
		{ }

		public DbSet<Address> Addresses { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<InventoryFinal> InventoryFinals { get; set; }
		public DbSet<InventorySnapshot> InventorySnapshots { get; set; }
		public DbSet<InventoryTransaction> InventoryTransactions { get; set; }
		public DbSet<Invoice> Invoices { get; set; }
		public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
		public DbSet<Item> Items { get; set; }
		public DbSet<ItemDetail> ItemDetails { get; set; }
		public DbSet<ItemImage> ItemImages { get; set; }
		public DbSet<ItemPrice> ItemPrices { get; set; }
		public DbSet<Note> Notes { get; set; }
		public DbSet<Phone> PhoneNumbers { get; set; }
		public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
		public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
		public DbSet<Vendor> Vendors { get; set; }
		public DbSet<Vendor_Item> VendorItems { get; set; }
		public DbSet<WebAddress> WebAddresses { get; set; }

	}
}