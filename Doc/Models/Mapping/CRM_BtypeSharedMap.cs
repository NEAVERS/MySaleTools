using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CRM_BtypeSharedMap : EntityTypeConfiguration<CRM_BtypeShared>
    {
        public CRM_BtypeSharedMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SharedEtypeID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CRM_BtypeShared");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CRMBtypeID).HasColumnName("CRMBtypeID");
            this.Property(t => t.SharedEtypeID).HasColumnName("SharedEtypeID");
        }
    }
}
