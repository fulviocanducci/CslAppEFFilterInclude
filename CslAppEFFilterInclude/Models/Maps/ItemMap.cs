using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CslAppEFFilterInclude.Models.Maps
{
    public sealed class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .UseIdentityColumn();
            builder.Property(c => c.Name);
            builder.HasMany(c => c.Sales)
                .WithOne(c => c.Item)
                .HasForeignKey(c => c.ItemId)
                .HasPrincipalKey(c => c.Id);
        }
    }
}
