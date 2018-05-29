using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_PtypeMap : EntityTypeConfiguration<OM_Ptype>
    {
        public OM_PtypeMap()
        {
            // Primary Key
            this.HasKey(t => t.TypeID);

            // Properties
            this.Property(t => t.PtypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PtypeClass_ID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OM_Ptype");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.PtypeClass_ID).HasColumnName("PtypeClass_ID");
            this.Property(t => t.IsSave).HasColumnName("IsSave");
        }
    }
}
