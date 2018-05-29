using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Assist_CheckItemsMap : EntityTypeConfiguration<Ac_Assist_CheckItems>
    {
        public Ac_Assist_CheckItemsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AscIds, t.UserCode, t.FullName });

            // Properties
            this.Property(t => t.AscIds)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Ac_Assist_CheckItems");
            this.Property(t => t.AscIds).HasColumnName("AscIds");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
        }
    }
}
