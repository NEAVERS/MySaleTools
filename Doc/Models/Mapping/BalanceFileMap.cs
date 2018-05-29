using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BalanceFileMap : EntityTypeConfiguration<BalanceFile>
    {
        public BalanceFileMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.FileName)
                .HasMaxLength(150);

            this.Property(t => t.FileSize)
                .HasMaxLength(50);

            this.Property(t => t.EtypeID)
                .HasMaxLength(200);

            this.Property(t => t.TempleName)
                .HasMaxLength(150);

            this.Property(t => t.TempleEtypeID)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BalanceFiles");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.FileSize).HasColumnName("FileSize");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
            this.Property(t => t.FileContent).HasColumnName("FileContent");
            this.Property(t => t.ZwCode).HasColumnName("ZwCode");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.TempleName).HasColumnName("TempleName");
            this.Property(t => t.TempleEtypeID).HasColumnName("TempleEtypeID");
            this.Property(t => t.TempleTime).HasColumnName("TempleTime");
            this.Property(t => t.CodeLength).HasColumnName("CodeLength");
            this.Property(t => t.Is100).HasColumnName("Is100");
        }
    }
}
