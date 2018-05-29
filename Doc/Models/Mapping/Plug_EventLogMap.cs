using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Plug_EventLogMap : EntityTypeConfiguration<Plug_EventLog>
    {
        public Plug_EventLogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.EventDate, t.Deleted });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.EventId)
                .HasMaxLength(2000);

            this.Property(t => t.Ip)
                .HasMaxLength(50);

            this.Property(t => t.Deleted)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Plug_EventLog");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EventDate).HasColumnName("EventDate");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.EventId).HasColumnName("EventId");
            this.Property(t => t.Ip).HasColumnName("Ip");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
        }
    }
}
