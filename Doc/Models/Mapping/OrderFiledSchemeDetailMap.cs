using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OrderFiledSchemeDetailMap : EntityTypeConfiguration<OrderFiledSchemeDetail>
    {
        public OrderFiledSchemeDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nId, t.SchemeId, t.OrderFiled, t.OrderBy, t.OrderID });

            // Properties
            this.Property(t => t.nId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.SchemeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderFiled)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OrderBy)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OrderFiledSchemeDetail");
            this.Property(t => t.nId).HasColumnName("nId");
            this.Property(t => t.SchemeId).HasColumnName("SchemeId");
            this.Property(t => t.OrderFiled).HasColumnName("OrderFiled");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
        }
    }
}
