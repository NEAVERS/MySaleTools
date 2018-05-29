using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class DiyIndexMap : EntityTypeConfiguration<DiyIndex>
    {
        public DiyIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.BillDate, t.EtypeId, t.IndexOrderId, t.Counts, t.Checke });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.EtypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.IndexOrderId)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Counts)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Checke)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DiyIndex");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.EtypeId).HasColumnName("EtypeId");
            this.Property(t => t.ToTalQty).HasColumnName("ToTalQty");
            this.Property(t => t.TotalMoney).HasColumnName("TotalMoney");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.IndexOrderId).HasColumnName("IndexOrderId");
            this.Property(t => t.Counts).HasColumnName("Counts");
            this.Property(t => t.Checke).HasColumnName("Checke");
        }
    }
}
