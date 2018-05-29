using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CommissionTypeMap : EntityTypeConfiguration<CommissionType>
    {
        public CommissionTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.TypeID, t.ParID, t.Sonnum, t.FullName, t.EtypeID, t.IsSystem, t.SonCount });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ParID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Sonnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.EtypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IsSystem)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SonCount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CommissionType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.ParID).HasColumnName("ParID");
            this.Property(t => t.Sonnum).HasColumnName("Sonnum");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
            this.Property(t => t.IsSystem).HasColumnName("IsSystem");
            this.Property(t => t.SonCount).HasColumnName("SonCount");
        }
    }
}
