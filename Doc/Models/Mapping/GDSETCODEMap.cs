using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class GDSETCODEMap : EntityTypeConfiguration<GDSETCODE>
    {
        public GDSETCODEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.SETCODECHAR, t.Des, t.FlagDate, t.Years, t.months, t.days });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SETCODECHAR)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Des)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FlagDate)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Years)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.months)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.days)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("GDSETCODE");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SETCODECHAR).HasColumnName("SETCODECHAR");
            this.Property(t => t.Des).HasColumnName("Des");
            this.Property(t => t.FlagDate).HasColumnName("FlagDate");
            this.Property(t => t.Years).HasColumnName("Years");
            this.Property(t => t.months).HasColumnName("months");
            this.Property(t => t.days).HasColumnName("days");
        }
    }
}
