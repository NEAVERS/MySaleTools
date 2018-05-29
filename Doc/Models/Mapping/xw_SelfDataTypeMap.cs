using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class xw_SelfDataTypeMap : EntityTypeConfiguration<xw_SelfDataType>
    {
        public xw_SelfDataTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.C_Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.PosDataVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("xw_SelfDataType");
            this.Property(t => t.C_Id).HasColumnName("_Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.PosDataVersion).HasColumnName("PosDataVersion");
        }
    }
}
