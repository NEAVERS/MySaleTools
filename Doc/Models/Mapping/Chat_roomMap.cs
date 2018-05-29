using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Chat_roomMap : EntityTypeConfiguration<Chat_room>
    {
        public Chat_roomMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.room_name)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.room_auto)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.room_owner)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.room_des)
                .IsFixedLength()
                .HasMaxLength(500);

            this.Property(t => t.room_title)
                .IsFixedLength()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("Chat_room");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.room_name).HasColumnName("room_name");
            this.Property(t => t.room_auto).HasColumnName("room_auto");
            this.Property(t => t.room_owner).HasColumnName("room_owner");
            this.Property(t => t.room_des).HasColumnName("room_des");
            this.Property(t => t.room_ref).HasColumnName("room_ref");
            this.Property(t => t.room_title).HasColumnName("room_title");
            this.Property(t => t.room_keep).HasColumnName("room_keep");
            this.Property(t => t.room_time).HasColumnName("room_time");
            this.Property(t => t.room_html).HasColumnName("room_html");
            this.Property(t => t.ip_protect).HasColumnName("ip_protect");
        }
    }
}
