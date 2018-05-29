using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Chat_helpbodyMap : EntityTypeConfiguration<Chat_helpbody>
    {
        public Chat_helpbodyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.alias)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Chat_helpbody");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.alias).HasColumnName("alias");
            this.Property(t => t.body).HasColumnName("body");
        }
    }
}
