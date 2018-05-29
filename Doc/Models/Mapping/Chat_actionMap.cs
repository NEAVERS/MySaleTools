using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Chat_actionMap : EntityTypeConfiguration<Chat_action>
    {
        public Chat_actionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.act_name)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.alias)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.toall)
                .IsFixedLength()
                .HasMaxLength(200);

            this.Property(t => t.toself)
                .IsFixedLength()
                .HasMaxLength(200);

            this.Property(t => t.toother)
                .IsFixedLength()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Chat_action");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.act_name).HasColumnName("act_name");
            this.Property(t => t.alias).HasColumnName("alias");
            this.Property(t => t.toall).HasColumnName("toall");
            this.Property(t => t.toself).HasColumnName("toself");
            this.Property(t => t.toother).HasColumnName("toother");
        }
    }
}
