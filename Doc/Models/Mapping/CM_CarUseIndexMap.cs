using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CM_CarUseIndexMap : EntityTypeConfiguration<CM_CarUseIndex>
    {
        public CM_CarUseIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.BillDate, t.BillCode, t.BillType, t.Stypeid, t.Etypeid });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.Stypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Etypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Explain)
                .HasMaxLength(256);

            this.Property(t => t.Dtypeid)
                .HasMaxLength(50);

            this.Property(t => t.checke)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CM_CarUseIndex");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.Etypeid).HasColumnName("Etypeid");
            this.Property(t => t.Explain).HasColumnName("Explain");
            this.Property(t => t.Dtypeid).HasColumnName("Dtypeid");
            this.Property(t => t.checke).HasColumnName("checke");
        }
    }
}
