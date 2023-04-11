using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EfViewMysQL.Models.Mappings
{
   public sealed class PeopleSexCountMapping : IEntityTypeConfiguration<PeopleSexCount>
   {
      public void Configure(EntityTypeBuilder<PeopleSexCount> builder)
      {
         builder.HasNoKey();
         builder.Property(x => x.Id).HasColumnName("sex_id");
         builder.Property(x => x.Sex).HasColumnName("sex");
         builder.Property(x => x.Count).HasColumnName("count");
         builder.HasIndex(x => x.Sex).IsUnique(false);
         builder.ToView("vPeopleSexCount");
      }
   }
}
