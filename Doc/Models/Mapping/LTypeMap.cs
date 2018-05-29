using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class LTypeMap : EntityTypeConfiguration<LType>
    {
        public LTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Leveal, t.SonNum, t.SonCount, t.UserCode, t.FullName, t.SysFlag, t.Deleted });

            // Properties
            this.Property(t => t.TypeID)
                .HasMaxLength(50);

            this.Property(t => t.ParID)
                .HasMaxLength(50);

            this.Property(t => t.Leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SonNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SonCount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KTypeID)
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.Name)
                .HasMaxLength(26);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.PyCode)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("LType");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.ParID).HasColumnName("ParID");
            this.Property(t => t.Leveal).HasColumnName("Leveal");
            this.Property(t => t.SonNum).HasColumnName("SonNum");
            this.Property(t => t.SonCount).HasColumnName("SonCount");
            this.Property(t => t.KTypeID).HasColumnName("KTypeID");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SysFlag).HasColumnName("SysFlag");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
        }
    }
}
