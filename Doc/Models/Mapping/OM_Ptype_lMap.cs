using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_Ptype_lMap : EntityTypeConfiguration<OM_Ptype_l>
    {
        public OM_Ptype_lMap()
        {
            // Primary Key
            this.HasKey(t => new { t.LoginUserLevelID, t.PtypeClassID });

            // Properties
            this.Property(t => t.LoginUserLevelID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PtypeClassID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OM_Ptype_l");
            this.Property(t => t.LoginUserLevelID).HasColumnName("LoginUserLevelID");
            this.Property(t => t.PtypeClassID).HasColumnName("PtypeClassID");
        }
    }
}
