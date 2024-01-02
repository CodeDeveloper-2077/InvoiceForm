using InvoiceForm.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvoiceForm.Configurations
{
    public class InvoicePositionConfiguration : IEntityTypeConfiguration<InvoicePosition>
    {
        public void Configure(EntityTypeBuilder<InvoicePosition> builder)
        {
            builder.HasKey(ip => ip.InvoicePositionId);
            builder.Property(ip => ip.Name)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.HasOne(ip => ip.Invoice)
                   .WithOne(i => i.InvoicePosition)
                   .HasForeignKey<Invoice>(i => i.Invoice_Id);

            builder.Property(ip => ip.InvoiceId).IsRequired();
        }
    }
}
