using Microsoft.EntityFrameworkCore;
using Northwind.Shared;

namespace Northwind.DataAccess
{
    public partial class NorthwindDBContext : DbContext
    {
        public NorthwindDBContext(DbContextOptions<NorthwindDBContext> options)
    : base(options)
        { }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrderDetails> Order_Details { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetails>()
                .HasKey(c => new { c.OrderID, c.ProductID });

            modelBuilder.Entity<Employee>()
                .HasMany(x => x.Employees)
                .WithOne(x => x.Manager)
                .HasForeignKey(x => x.ReportsTo);
        }
    }

}