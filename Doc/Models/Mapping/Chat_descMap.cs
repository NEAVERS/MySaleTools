using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Chat_descMap : EntityTypeConfiguration<Chat_desc>
    {
        public Chat_descMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.alias)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.describ)
                .IsFixedLength()
                .HasMaxLength(254);

            // Table & Column Mappings
            this.ToTable("Chat_desc");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.alias).HasColumnName("alias");
            this.Property(t => t.describ).HasColumnName("describ");
        }
    }
}
