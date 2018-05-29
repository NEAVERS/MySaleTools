using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_QuestionReplyMap : EntityTypeConfiguration<OM_QuestionReply>
    {
        public OM_QuestionReplyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Contents)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Reply)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.CreatorName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ModifierName)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("OM_QuestionReply");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Contents).HasColumnName("Contents");
            this.Property(t => t.Reply).HasColumnName("Reply");
            this.Property(t => t.CreatorId).HasColumnName("CreatorId");
            this.Property(t => t.CreatorName).HasColumnName("CreatorName");
            this.Property(t => t.CreatedTime).HasColumnName("CreatedTime");
            this.Property(t => t.ModifierId).HasColumnName("ModifierId");
            this.Property(t => t.ModifierName).HasColumnName("ModifierName");
            this.Property(t => t.ModifiedTime).HasColumnName("ModifiedTime");
        }
    }
}
