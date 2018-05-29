using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Chat_ip_lockMap : EntityTypeConfiguration<Chat_ip_lock>
    {
        public Chat_ip_lockMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ip)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Chat_ip_lock");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ip).HasColumnName("ip");
            this.Property(t => t.end_time).HasColumnName("end_time");
        }
    }
}
