using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class IntercourseSettingMap : EntityTypeConfiguration<IntercourseSetting>
    {
        public IntercourseSettingMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BtypeId)
                .HasMaxLength(50);

            this.Property(t => t.StypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("IntercourseSetting");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BtypeId).HasColumnName("BtypeId");
            this.Property(t => t.StypeId).HasColumnName("StypeId");
            this.Property(t => t.LimitDay).HasColumnName("LimitDay");
        }
    }
}
