using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Sms_AlarmVchDefineMap : EntityTypeConfiguration<Sms_AlarmVchDefine>
    {
        public Sms_AlarmVchDefineMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.VchName)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Sms_AlarmVchDefine");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.VchType).HasColumnName("VchType");
            this.Property(t => t.VchName).HasColumnName("VchName");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
