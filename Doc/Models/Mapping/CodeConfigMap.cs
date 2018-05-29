using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CodeConfigMap : EntityTypeConfiguration<CodeConfig>
    {
        public CodeConfigMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Billtype, t.Code1, t.Code2, t.Code3, t.Code4, t.Code5, t.Code6, t.Code7, t.Code8, t.Code9, t.Code10, t.Code11, t.Code12, t.EtypeID, t.Code13 });

            // Properties
            this.Property(t => t.Billtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code1)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code2)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code3)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code4)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code5)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code6)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code7)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code8)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code9)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code10)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code11)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code12)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.EtypeID)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Code13)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("CodeConfig");
            this.Property(t => t.Billtype).HasColumnName("Billtype");
            this.Property(t => t.Code1).HasColumnName("Code1");
            this.Property(t => t.Code2).HasColumnName("Code2");
            this.Property(t => t.Code3).HasColumnName("Code3");
            this.Property(t => t.Code4).HasColumnName("Code4");
            this.Property(t => t.Code5).HasColumnName("Code5");
            this.Property(t => t.Code6).HasColumnName("Code6");
            this.Property(t => t.Code7).HasColumnName("Code7");
            this.Property(t => t.Code8).HasColumnName("Code8");
            this.Property(t => t.Code9).HasColumnName("Code9");
            this.Property(t => t.Code10).HasColumnName("Code10");
            this.Property(t => t.Code11).HasColumnName("Code11");
            this.Property(t => t.Code12).HasColumnName("Code12");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
            this.Property(t => t.Code13).HasColumnName("Code13");
        }
    }
}
