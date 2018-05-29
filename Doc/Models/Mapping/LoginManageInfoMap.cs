using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class LoginManageInfoMap : EntityTypeConfiguration<LoginManageInfo>
    {
        public LoginManageInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.ETypeID);

            // Properties
            this.Property(t => t.ETypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ManageType)
                .HasMaxLength(50);

            this.Property(t => t.ManageType1)
                .HasMaxLength(50);

            this.Property(t => t.ManageType2)
                .HasMaxLength(50);

            this.Property(t => t.ManageType3)
                .HasMaxLength(50);

            this.Property(t => t.ManageType4)
                .HasMaxLength(50);

            this.Property(t => t.ManageType5)
                .HasMaxLength(50);

            this.Property(t => t.ManageValue)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LoginManageInfo");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.ManageType).HasColumnName("ManageType");
            this.Property(t => t.ManageType1).HasColumnName("ManageType1");
            this.Property(t => t.ManageType2).HasColumnName("ManageType2");
            this.Property(t => t.ManageType3).HasColumnName("ManageType3");
            this.Property(t => t.ManageType4).HasColumnName("ManageType4");
            this.Property(t => t.ManageType5).HasColumnName("ManageType5");
            this.Property(t => t.ManageValue).HasColumnName("ManageValue");
        }
    }
}
