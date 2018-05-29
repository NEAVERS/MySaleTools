using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class nVipCardTypeChangeMap : EntityTypeConfiguration<nVipCardTypeChange>
    {
        public nVipCardTypeChangeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VipCardID, t.OldVipCardTypeID, t.NewVipCardTypeID });

            // Properties
            this.Property(t => t.VipCardID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OldVipCardTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NewVipCardTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("nVipCardTypeChange");
            this.Property(t => t.VipCardID).HasColumnName("VipCardID");
            this.Property(t => t.OldVipCardTypeID).HasColumnName("OldVipCardTypeID");
            this.Property(t => t.NewVipCardTypeID).HasColumnName("NewVipCardTypeID");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.ChangeDate).HasColumnName("ChangeDate");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.OperatStyle).HasColumnName("OperatStyle");
        }
    }
}
