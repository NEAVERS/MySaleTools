using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class EventMap : EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            // Primary Key
            this.HasKey(t => t.EventId);

            // Properties
            this.Property(t => t.EventId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EventName)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Event");
            this.Property(t => t.EventId).HasColumnName("EventId");
            this.Property(t => t.EventName).HasColumnName("EventName");
        }
    }
}
