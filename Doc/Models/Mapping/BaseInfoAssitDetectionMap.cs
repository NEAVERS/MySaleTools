using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BaseInfoAssitDetectionMap : EntityTypeConfiguration<BaseInfoAssitDetection>
    {
        public BaseInfoAssitDetectionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.BaseinfoType, t.TableName, t.TableColumnname, t.IfCategory, t.IfDelete, t.IfMove, t.IfUsed, t.Explain, t.Conditions });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BaseinfoType)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.TableName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.TableColumnname)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Explain)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.Conditions)
                .IsRequired()
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("BaseInfoAssitDetection");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BaseinfoType).HasColumnName("BaseinfoType");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.TableColumnname).HasColumnName("TableColumnname");
            this.Property(t => t.IfCategory).HasColumnName("IfCategory");
            this.Property(t => t.IfDelete).HasColumnName("IfDelete");
            this.Property(t => t.IfMove).HasColumnName("IfMove");
            this.Property(t => t.IfUsed).HasColumnName("IfUsed");
            this.Property(t => t.Explain).HasColumnName("Explain");
            this.Property(t => t.Conditions).HasColumnName("Conditions");
        }
    }
}
