using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class MonthATypeHistoryMap : EntityTypeConfiguration<MonthATypeHistory>
    {
        public MonthATypeHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ATypeID);

            // Properties
            this.Property(t => t.ATypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MonthATypeHistory");
            this.Property(t => t.period).HasColumnName("period");
            this.Property(t => t.ATypeID).HasColumnName("ATypeID");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.BqTotal).HasColumnName("BqTotal");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.NTotal).HasColumnName("NTotal");
            this.Property(t => t.NBqTotal).HasColumnName("NBqTotal");
            this.Property(t => t.CID).HasColumnName("CID");
        }
    }
}
