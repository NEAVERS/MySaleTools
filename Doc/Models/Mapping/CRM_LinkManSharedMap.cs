using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CRM_LinkManSharedMap : EntityTypeConfiguration<CRM_LinkManShared>
    {
        public CRM_LinkManSharedMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SharedEtypeID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CRM_LinkManShared");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CRMLinkManID).HasColumnName("CRMLinkManID");
            this.Property(t => t.SharedEtypeID).HasColumnName("SharedEtypeID");
        }
    }
}
