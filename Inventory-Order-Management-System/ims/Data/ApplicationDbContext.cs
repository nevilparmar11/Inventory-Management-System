using ims.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ims.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<ims.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<ims.Models.Bill> Bill { get; set; }

        public DbSet<ims.Models.BillType> BillType { get; set; }

        public DbSet<ims.Models.Branch> Branch { get; set; }

        public DbSet<ims.Models.CashBank> CashBank { get; set; }

        public DbSet<ims.Models.Currency> Currency { get; set; }

        public DbSet<ims.Models.Customer> Customer { get; set; }

        public DbSet<ims.Models.CustomerType> CustomerType { get; set; }

        public DbSet<ims.Models.GoodsReceivedNote> GoodsReceivedNote { get; set; }

        public DbSet<ims.Models.Invoice> Invoice { get; set; }

        public DbSet<ims.Models.InvoiceType> InvoiceType { get; set; }

        public DbSet<ims.Models.NumberSequence> NumberSequence { get; set; }

        public DbSet<ims.Models.PaymentReceive> PaymentReceive { get; set; }

        public DbSet<ims.Models.PaymentType> PaymentType { get; set; }

        public DbSet<ims.Models.PaymentVoucher> PaymentVoucher { get; set; }

        public DbSet<ims.Models.Product> Product { get; set; }

        public DbSet<ims.Models.ProductType> ProductType { get; set; }

        public DbSet<ims.Models.PurchaseOrder> PurchaseOrder { get; set; }

        public DbSet<ims.Models.PurchaseOrderLine> PurchaseOrderLine { get; set; }

        public DbSet<ims.Models.PurchaseType> PurchaseType { get; set; }

        public DbSet<ims.Models.SalesOrder> SalesOrder { get; set; }

        public DbSet<ims.Models.SalesOrderLine> SalesOrderLine { get; set; }

        public DbSet<ims.Models.SalesType> SalesType { get; set; }

        public DbSet<ims.Models.Shipment> Shipment { get; set; }

        public DbSet<ims.Models.ShipmentType> ShipmentType { get; set; }

        public DbSet<ims.Models.UnitOfMeasure> UnitOfMeasure { get; set; }

        public DbSet<ims.Models.Vendor> Vendor { get; set; }

        public DbSet<ims.Models.VendorType> VendorType { get; set; }

        public DbSet<ims.Models.Warehouse> Warehouse { get; set; }

        public DbSet<ims.Models.UserProfile> UserProfile { get; set; }
    }
}
