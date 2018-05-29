using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_TableMap : EntityTypeConfiguration<Ac_Table>
    {
        public Ac_TableMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AcId, t.UserCode, t.FullName, t.IsUsed });

            // Properties
            this.Property(t => t.AcId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(200);

            this.Property(t => t.EType)
                .HasMaxLength(50);

            this.Property(t => t.IsUsed)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Ac_Table");
            this.Property(t => t.AcId).HasColumnName("AcId");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Len1).HasColumnName("Len1");
            this.Property(t => t.Len2).HasColumnName("Len2");
            this.Property(t => t.Len3).HasColumnName("Len3");
            this.Property(t => t.Len4).HasColumnName("Len4");
            this.Property(t => t.Len5).HasColumnName("Len5");
            this.Property(t => t.Len6).HasColumnName("Len6");
            this.Property(t => t.Len7).HasColumnName("Len7");
            this.Property(t => t.Len8).HasColumnName("Len8");
            this.Property(t => t.Len9).HasColumnName("Len9");
            this.Property(t => t.Len10).HasColumnName("Len10");
            this.Property(t => t.EType).HasColumnName("EType");
            this.Property(t => t.CreateDateTime).HasColumnName("CreateDateTime");
            this.Property(t => t.IsUsed).HasColumnName("IsUsed");
        }
    }
}
