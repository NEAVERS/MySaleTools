using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OA_UserInformationMap : EntityTypeConfiguration<OA_UserInformation>
    {
        public OA_UserInformationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Experience });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ETypeID_UserTypeID)
                .HasMaxLength(50);

            this.Property(t => t.Experience)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OA_UserInformation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ETypeID_UserTypeID).HasColumnName("ETypeID_UserTypeID");
            this.Property(t => t.Experience).HasColumnName("Experience");
            this.Property(t => t.Add).HasColumnName("Add");
            this.Property(t => t.Reply).HasColumnName("Reply");
        }
    }
}
