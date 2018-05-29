using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_AdDebtMap : EntityTypeConfiguration<vWeb_AdDebt>
    {
        public vWeb_AdDebtMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.FullName, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.BtypeId)
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .HasMaxLength(26);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vWeb_AdDebt");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.BtypeId).HasColumnName("BtypeId");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
