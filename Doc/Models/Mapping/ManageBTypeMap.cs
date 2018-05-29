using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ManageBTypeMap : EntityTypeConfiguration<ManageBType>
    {
        public ManageBTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Type);

            // Properties
            this.Property(t => t.ManageBtypeID)
                .HasMaxLength(50);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ManageBType");
            this.Property(t => t.ManageBtypeID).HasColumnName("ManageBtypeID");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.Type).HasColumnName("Type");
        }
    }
}
