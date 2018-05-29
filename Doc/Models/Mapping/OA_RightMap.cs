using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OA_RightMap : EntityTypeConfiguration<OA_Right>
    {
        public OA_RightMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ETypeID_EmployeeTypeID)
                .HasMaxLength(50);

            this.Property(t => t.CatalogID)
                .HasMaxLength(30);

            this.Property(t => t.RightString)
                .HasMaxLength(20);

            this.Property(t => t.ETypeID_ModifierTypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OA_Right");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ETypeID_EmployeeTypeID).HasColumnName("ETypeID_EmployeeTypeID");
            this.Property(t => t.CatalogID).HasColumnName("CatalogID");
            this.Property(t => t.RightString).HasColumnName("RightString");
            this.Property(t => t.ModifyDate).HasColumnName("ModifyDate");
            this.Property(t => t.ETypeID_ModifierTypeID).HasColumnName("ETypeID_ModifierTypeID");
        }
    }
}
