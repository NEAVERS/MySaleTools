using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class UserPowerRangeMap : EntityTypeConfiguration<UserPowerRange>
    {
        public UserPowerRangeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ListID, t.EtypeID, t.TypeID, t.BaseType });

            // Properties
            this.Property(t => t.ListID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EtypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TypeID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UserPowerRange");
            this.Property(t => t.ListID).HasColumnName("ListID");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.BaseType).HasColumnName("BaseType");
        }
    }
}
