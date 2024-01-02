using InvoiceForm.Configurations;
using InvoiceForm.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceForm.Data
{
    internal class InvoiceDb : DbContext
    {
        public InvoiceDb(DbContextOptions<InvoiceDb> options)
            : base(options)
        {

        }

        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoicePosition> InvoicePositions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new InvoicePositionConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=InvoiceDb;Integrated Security=True;");
        }
    }
}
