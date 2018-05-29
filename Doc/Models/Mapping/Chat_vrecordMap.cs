using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Chat_vrecordMap : EntityTypeConfiguration<Chat_vrecord>
    {
        public Chat_vrecordMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.username)
                .IsFixedLength()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Chat_vrecord");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.votetype).HasColumnName("votetype");
            this.Property(t => t.end_time).HasColumnName("end_time");
            this.Property(t => t.temp_level).HasColumnName("temp_level");
        }
    }
}
