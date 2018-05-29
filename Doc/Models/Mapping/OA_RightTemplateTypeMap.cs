using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OA_RightTemplateTypeMap : EntityTypeConfiguration<OA_RightTemplateType>
    {
        public OA_RightTemplateTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.TemplateName)
                .HasMaxLength(50);

            this.Property(t => t.ETypeID_CreatorTypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OA_RightTemplateType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TemplateName).HasColumnName("TemplateName");
            this.Property(t => t.ModifyDate).HasColumnName("ModifyDate");
            this.Property(t => t.ETypeID_CreatorTypeID).HasColumnName("ETypeID_CreatorTypeID");
        }
    }
}
