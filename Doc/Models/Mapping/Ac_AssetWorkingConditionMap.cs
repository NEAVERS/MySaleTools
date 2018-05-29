using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_AssetWorkingConditionMap : EntityTypeConfiguration<Ac_AssetWorkingCondition>
    {
        public Ac_AssetWorkingConditionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Deleted, t.SysRow });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.SysRow)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Ac_AssetWorkingCondition");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.SysRow).HasColumnName("SysRow");
        }
    }
}
