using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OtherInOutTypeMap : EntityTypeConfiguration<OtherInOutType>
    {
        public OtherInOutTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.FullName, t.ATypeID, t.ATypeID1 });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ATypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ATypeID1)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OtherInOutType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.ATypeID).HasColumnName("ATypeID");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.ATypeID1).HasColumnName("ATypeID1");
            this.Property(t => t.InOutType).HasColumnName("InOutType");
        }
    }
}
