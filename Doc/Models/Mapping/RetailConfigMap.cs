using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class RetailConfigMap : EntityTypeConfiguration<RetailConfig>
    {
        public RetailConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.LoginUserId);

            // Properties
            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.BTypeID)
                .HasMaxLength(50);

            this.Property(t => t.KTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ATypeID)
                .HasMaxLength(50);

            this.Property(t => t.LoginUserId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RetailConfig");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.BTypeID).HasColumnName("BTypeID");
            this.Property(t => t.KTypeID).HasColumnName("KTypeID");
            this.Property(t => t.ATypeID).HasColumnName("ATypeID");
            this.Property(t => t.LoginUserId).HasColumnName("LoginUserId");
        }
    }
}
