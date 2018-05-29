using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class xw_SelfDataMap : EntityTypeConfiguration<xw_SelfData>
    {
        public xw_SelfDataMap()
        {
            // Primary Key
            this.HasKey(t => t.C_Id);

            // Properties
            this.Property(t => t.TypeId)
                .HasMaxLength(50);

            this.Property(t => t.ParTypeId)
                .HasMaxLength(50);

            this.Property(t => t.FullName)
                .HasMaxLength(500);

            this.Property(t => t.UserCode)
                .HasMaxLength(500);

            this.Property(t => t.PyCode)
                .HasMaxLength(500);

            this.Property(t => t.Field1)
                .HasMaxLength(500);

            this.Property(t => t.Field2)
                .HasMaxLength(500);

            this.Property(t => t.Field3)
                .HasMaxLength(500);

            this.Property(t => t.Field4)
                .HasMaxLength(500);

            this.Property(t => t.PosDataVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("xw_SelfData");
            this.Property(t => t.C_Id).HasColumnName("_Id");
            this.Property(t => t.DataTypeId).HasColumnName("DataTypeId");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.ParTypeId).HasColumnName("ParTypeId");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.SonNum).HasColumnName("SonNum");
            this.Property(t => t.SonCount).HasColumnName("SonCount");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.Field1).HasColumnName("Field1");
            this.Property(t => t.Field2).HasColumnName("Field2");
            this.Property(t => t.Field3).HasColumnName("Field3");
            this.Property(t => t.Field4).HasColumnName("Field4");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.PosDataVersion).HasColumnName("PosDataVersion");
        }
    }
}
