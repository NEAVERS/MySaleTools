using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosPtypeColorSizeViewMap : EntityTypeConfiguration<PosPtypeColorSizeView>
    {
        public PosPtypeColorSizeViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ColorID, t.SizeID, t.sizeorderid, t.colororderid });

            // Properties
            this.Property(t => t.ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.ColorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SizeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sizeorderid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.colororderid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosPtypeColorSizeView");
            this.Property(t => t.ptypeid).HasColumnName("ptypeid");
            this.Property(t => t.ColorID).HasColumnName("ColorID");
            this.Property(t => t.SizeID).HasColumnName("SizeID");
            this.Property(t => t.sizeorderid).HasColumnName("sizeorderid");
            this.Property(t => t.colororderid).HasColumnName("colororderid");
            this.Property(t => t.updatetag).HasColumnName("updatetag");
        }
    }
}
