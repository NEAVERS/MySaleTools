using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BillSaveTimeLogMap : EntityTypeConfiguration<BillSaveTimeLog>
    {
        public BillSaveTimeLogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SaveDate, t.BillTypeID, t.BillCode, t.FunctionName, t.Elapsed });

            // Properties
            this.Property(t => t.BillTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FunctionName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Elapsed)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BillSaveTimeLog");
            this.Property(t => t.SaveDate).HasColumnName("SaveDate");
            this.Property(t => t.BillTypeID).HasColumnName("BillTypeID");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.FunctionOrder).HasColumnName("FunctionOrder");
            this.Property(t => t.FunctionName).HasColumnName("FunctionName");
            this.Property(t => t.Elapsed).HasColumnName("Elapsed");
        }
    }
}
