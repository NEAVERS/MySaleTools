using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class TemplateListTableMap : EntityTypeConfiguration<TemplateListTable>
    {
        public TemplateListTableMap()
        {
            // Primary Key
            this.HasKey(t => t.TemplateID);

            // Properties
            this.Property(t => t.TemplateID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.comment)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TemplateListTable");
            this.Property(t => t.TemplateID).HasColumnName("TemplateID");
            this.Property(t => t.Ptypeid).HasColumnName("Ptypeid");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
