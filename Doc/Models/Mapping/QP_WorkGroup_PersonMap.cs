using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_WorkGroup_PersonMap : EntityTypeConfiguration<QP_WorkGroup_Person>
    {
        public QP_WorkGroup_PersonMap()
        {
            // Primary Key
            this.HasKey(t => new { t.WorkGroupID, t.ETypeID });

            // Properties
            this.Property(t => t.WorkGroupID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ETypeID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QP_WorkGroup_Person");
            this.Property(t => t.WorkGroupID).HasColumnName("WorkGroupID");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
        }
    }
}
