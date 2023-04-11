using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfViewMysQL.Models.Mappings
{
   public sealed partial class PeopleMapping : IEntityTypeConfiguration<People>
   {
      public void Configure(EntityTypeBuilder<People> builder)
      {
         builder.ToTable("peoples");
         builder.HasKey(x => x.Id);
         builder.Property(x => x.Id)
            .UseMySqlIdentityColumn()
            .HasColumnName("id");

         builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasMaxLength(100)
            .IsRequired();

         builder.Property(x => x.Sex)
            .HasColumnName("sex");
            //.HasConversion<int>();
      }
   }
}
