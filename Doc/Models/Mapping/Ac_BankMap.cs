using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_BankMap : EntityTypeConfiguration<Ac_Bank>
    {
        public Ac_BankMap()
        {
            // Primary Key
            this.HasKey(t => t.nId);

            // Properties
            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .HasMaxLength(400);

            this.Property(t => t.CreateBank)
                .HasMaxLength(400);

            this.Property(t => t.BankType)
                .HasMaxLength(200);

            this.Property(t => t.ATypeId)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Ac_Bank");
            this.Property(t => t.nId).HasColumnName("nId");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.CreateBank).HasColumnName("CreateBank");
            this.Property(t => t.BankType).HasColumnName("BankType");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.IsBank).HasColumnName("IsBank");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
        }
    }
}
