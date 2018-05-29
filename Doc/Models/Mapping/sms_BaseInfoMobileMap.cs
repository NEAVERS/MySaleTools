using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sms_BaseInfoMobileMap : EntityTypeConfiguration<sms_BaseInfoMobile>
    {
        public sms_BaseInfoMobileMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TypeID)
                .HasMaxLength(50);

            this.Property(t => t.Mobile)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("sms_BaseInfoMobile");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.nType).HasColumnName("nType");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
