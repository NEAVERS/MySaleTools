using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Chat_voteMap : EntityTypeConfiguration<Chat_vote>
    {
        public Chat_voteMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.votename)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.voteoptions)
                .IsFixedLength()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Chat_vote");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.exp_num).HasColumnName("exp_num");
            this.Property(t => t.votename).HasColumnName("votename");
            this.Property(t => t.voteoptions).HasColumnName("voteoptions");
            this.Property(t => t.votenum).HasColumnName("votenum");
            this.Property(t => t.voted_user).HasColumnName("voted_user");
            this.Property(t => t.begin_time).HasColumnName("begin_time");
            this.Property(t => t.end_flag).HasColumnName("end_flag");
        }
    }
}
