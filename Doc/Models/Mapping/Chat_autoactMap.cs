using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Chat_autoactMap : EntityTypeConfiguration<Chat_autoact>
    {
        public Chat_autoactMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.text_body)
                .IsFixedLength()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Chat_autoact");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.text_body).HasColumnName("text_body");
        }
    }
}
