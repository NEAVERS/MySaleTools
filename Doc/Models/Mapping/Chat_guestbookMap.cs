using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Chat_guestbookMap : EntityTypeConfiguration<Chat_guestbook>
    {
        public Chat_guestbookMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.who)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.towho)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.ip)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.email)
                .IsFixedLength()
                .HasMaxLength(250);

            this.Property(t => t.web)
                .IsFixedLength()
                .HasMaxLength(250);

            this.Property(t => t.addr)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.text_title)
                .IsFixedLength()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Chat_guestbook");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.who).HasColumnName("who");
            this.Property(t => t.towho).HasColumnName("towho");
            this.Property(t => t.secret).HasColumnName("secret");
            this.Property(t => t.ip).HasColumnName("ip");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.web).HasColumnName("web");
            this.Property(t => t.addr).HasColumnName("addr");
            this.Property(t => t.post_time).HasColumnName("post_time");
            this.Property(t => t.text_title).HasColumnName("text_title");
            this.Property(t => t.text_body).HasColumnName("text_body");
        }
    }
}
