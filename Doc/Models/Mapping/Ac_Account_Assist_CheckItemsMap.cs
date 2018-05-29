using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Account_Assist_CheckItemsMap : EntityTypeConfiguration<Ac_Account_Assist_CheckItems>
    {
        public Ac_Account_Assist_CheckItemsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.STypeId, t.ATypeId });

            // Properties
            this.Property(t => t.STypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ATypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DTypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_Account_Assist_CheckItems");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Ascids).HasColumnName("Ascids");
            this.Property(t => t.IsRequired).HasColumnName("IsRequired");
            this.Property(t => t.DTypeID).HasColumnName("DTypeID");
        }
    }
}
