using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AddPrintCountRecordMap : EntityTypeConfiguration<AddPrintCountRecord>
    {
        public AddPrintCountRecordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillType, t.BillNumberId, t.etypeid, t.addprintcount });

            // Properties
            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.addprintcount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AddPrintCountRecord");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.addprintcount).HasColumnName("addprintcount");
        }
    }
}
