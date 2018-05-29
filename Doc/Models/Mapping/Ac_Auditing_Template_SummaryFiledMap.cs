using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Auditing_Template_SummaryFiledMap : EntityTypeConfiguration<Ac_Auditing_Template_SummaryFiled>
    {
        public Ac_Auditing_Template_SummaryFiledMap()
        {
            // Primary Key
            this.HasKey(t => t.FiledID);

            // Properties
            this.Property(t => t.Filed)
                .HasMaxLength(50);

            this.Property(t => t.TableName)
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Ac_Auditing_Template_SummaryFiled");
            this.Property(t => t.FiledID).HasColumnName("FiledID");
            this.Property(t => t.Filed).HasColumnName("Filed");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
