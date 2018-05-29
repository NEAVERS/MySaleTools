using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Chat_userMap : EntityTypeConfiguration<Chat_user>
    {
        public Chat_userMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.username)
                .IsFixedLength()
                .HasMaxLength(200);

            this.Property(t => t.passwd)
                .IsFixedLength()
                .HasMaxLength(200);

            this.Property(t => t.email)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.remand)
                .IsFixedLength()
                .HasMaxLength(500);

            this.Property(t => t.answer)
                .IsFixedLength()
                .HasMaxLength(500);

            this.Property(t => t.bgcolor)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.temppass)
                .IsFixedLength()
                .HasMaxLength(500);

            this.Property(t => t.oicq)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Chat_user");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.passwd).HasColumnName("passwd");
            this.Property(t => t.sex).HasColumnName("sex");
            this.Property(t => t.user_level).HasColumnName("user_level");
            this.Property(t => t.log_time).HasColumnName("log_time");
            this.Property(t => t.visit_num).HasColumnName("visit_num");
            this.Property(t => t.in_time).HasColumnName("in_time");
            this.Property(t => t.out_info).HasColumnName("out_info");
            this.Property(t => t.out_time).HasColumnName("out_time");
            this.Property(t => t.exp_num).HasColumnName("exp_num");
            this.Property(t => t.f_size).HasColumnName("f_size");
            this.Property(t => t.l_height).HasColumnName("l_height");
            this.Property(t => t.n_color).HasColumnName("n_color");
            this.Property(t => t.s_color).HasColumnName("s_color");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.remand).HasColumnName("remand");
            this.Property(t => t.answer).HasColumnName("answer");
            this.Property(t => t.bgcolor).HasColumnName("bgcolor");
            this.Property(t => t.temppass).HasColumnName("temppass");
            this.Property(t => t.oicq).HasColumnName("oicq");
            this.Property(t => t.saved).HasColumnName("saved");
        }
    }
}
