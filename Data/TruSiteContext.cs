using Microsoft.EntityFrameworkCore;
using TruSite.Api.Entities;

namespace TruSite.Api.Data
{
    public class TruSiteContext : DbContext
    {
		public TruSiteContext(DbContextOptions<TruSiteContext> options) : base(options)
        { }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<InventoryFinal> InventoryFinals { get; set; }
        public virtual DbSet<InventorySnapshot> InventorySnapshots { get; set; }
        public virtual DbSet<InventoryTransaction> InventoryTransactions { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemDetail> ItemDetails { get; set; }
        public virtual DbSet<ItemImage> ItemImages { get; set; }
        public virtual DbSet<ItemPrice> ItemPrices { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Phone> PhoneNumbers { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Vendor_Item> VendorItems { get; set; }
        public virtual DbSet<WebAddress> WebAddresses { get; set; }
    }
}