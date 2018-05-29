using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosBarCodeViewMap : EntityTypeConfiguration<PosBarCodeView>
    {
        public PosBarCodeViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.colorid, t.sizeid, t.BarTypeid, t.PRI });

            // Properties
            this.Property(t => t.ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.colorid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sizeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BarTypeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FullBarCode)
                .HasMaxLength(200);

            this.Property(t => t.PRI)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosBarCodeView");
            this.Property(t => t.ptypeid).HasColumnName("ptypeid");
            this.Property(t => t.colorid).HasColumnName("colorid");
            this.Property(t => t.sizeid).HasColumnName("sizeid");
            this.Property(t => t.BarTypeid).HasColumnName("BarTypeid");
            this.Property(t => t.FullBarCode).HasColumnName("FullBarCode");
            this.Property(t => t.PRI).HasColumnName("PRI");
        }
    }
}
