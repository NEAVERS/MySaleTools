using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class nVipJfSetMap : EntityTypeConfiguration<nVipJfSet>
    {
        public nVipJfSetMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("nVipJfSet");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Jf).HasColumnName("Jf");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.TimeValue).HasColumnName("TimeValue");
        }
    }
}
