using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Advantage_standardMap : EntityTypeConfiguration<Advantage_standard>
    {
        public Advantage_standardMap()
        {
            // Primary Key
            this.HasKey(t => new { t.StandardCode, t.StandardName, t.Type, t.Dates });

            // Properties
            this.Property(t => t.StandardCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.StandardName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Etypeid)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Dates)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.explain)
                .HasMaxLength(255);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Advantage_standard");
            this.Property(t => t.StandardCode).HasColumnName("StandardCode");
            this.Property(t => t.StandardName).HasColumnName("StandardName");
            this.Property(t => t.Etypeid).HasColumnName("Etypeid");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Dates).HasColumnName("Dates");
            this.Property(t => t.LowQty).HasColumnName("LowQty");
            this.Property(t => t.HighQty).HasColumnName("HighQty");
            this.Property(t => t.Advantage_Total).HasColumnName("Advantage_Total");
            this.Property(t => t.explain).HasColumnName("explain");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
        }
    }
}
