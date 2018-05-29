using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Chat_recordMap : EntityTypeConfiguration<Chat_record>
    {
        public Chat_recordMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.occ_env)
                .IsFixedLength()
                .HasMaxLength(200);

            this.Property(t => t.for_what)
                .IsFixedLength()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Chat_record");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.occ_time).HasColumnName("occ_time");
            this.Property(t => t.occ_env).HasColumnName("occ_env");
            this.Property(t => t.for_what).HasColumnName("for_what");
        }
    }
}
