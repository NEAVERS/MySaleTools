using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BarCode_ExtMap : EntityTypeConfiguration<BarCode_Ext>
    {
        public BarCode_ExtMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BarCodeID, t.StartNum, t.EndNum, t.SourceID });

            // Properties
            this.Property(t => t.BarCodeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StartNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EndNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SourceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BarCode_Ext");
            this.Property(t => t.BarCodeID).HasColumnName("BarCodeID");
            this.Property(t => t.StartNum).HasColumnName("StartNum");
            this.Property(t => t.EndNum).HasColumnName("EndNum");
            this.Property(t => t.SourceID).HasColumnName("SourceID");
        }
    }
}
