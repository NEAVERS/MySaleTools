using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Crm_Schedule_EtypeMap : EntityTypeConfiguration<Crm_Schedule_Etype>
    {
        public Crm_Schedule_EtypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Schedule_ID, t.EtypeID });

            // Properties
            this.Property(t => t.Schedule_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EtypeID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Crm_Schedule_Etype");
            this.Property(t => t.Schedule_ID).HasColumnName("Schedule_ID");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
        }
    }
}
