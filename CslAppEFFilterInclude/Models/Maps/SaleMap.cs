using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CslAppEFFilterInclude.Models.Maps
{
    public sealed class SaleMap : IEntityTypeConfiguration<Sales>
    {
        public void Configure(EntityTypeBuilder<Sales> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .UseIdentityColumn();
            builder.Property(c => c.Value)
                .IsRequired();
            builder.HasOne(c => c.Item)
                .WithMany(c => c.Sales)
                .HasForeignKey(c => c.ItemId)
                .HasPrincipalKey(c => c.Id);
        }
    }
}
