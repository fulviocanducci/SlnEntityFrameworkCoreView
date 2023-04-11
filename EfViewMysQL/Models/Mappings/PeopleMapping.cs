using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfViewMysQL.Models.Mappings
{
   public sealed class PeopleMapping : IEntityTypeConfiguration<People>
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
            .HasColumnName("sex")
            .HasConversion<uint>();         
      }
   }
}
