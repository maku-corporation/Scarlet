using Domain.Entities.VOne;
using Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Database.Context
{
    public class ScarletContext : DbContext, IScarletContext
    {
        public ScarletContext()
        {
            
        }

        public ScarletContext(DbContextOptions<ScarletContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coupon>().ToTable("Coupon");
            // ...rest

            //modelBuilder.Entity<Coupon>()
            //    .HasOne(a => a.Value)
            //    .WithOne(b => b.Coupon)
            //    .HasForeignKey<Value>(b => b.CouponRef);

            //modelBuilder.Entity<Coupon>()
            //    .HasOne(a => a.CouponAssets)
            //    .WithOne(b => b.Coupon)
            //    .HasForeignKey<CouponAssets>(b => b.CouponRef);

            //modelBuilder.Entity<Coupon>()
            //    .HasOne(a => a.Metadata)
            //    .WithOne(b => b.Coupon)
            //    .HasForeignKey<Metadata>(b => b.CouponRef);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Barcode> Barcodes { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<CouponAssets> CouponsAssets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Metadata> Metadatas { get; set; }
        public DbSet<QRCode> QRCodes { get; set; }
        public DbSet<Value> Values { get; set; }
    }
}
