using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class TCBillMap : EntityTypeConfiguration<TCBill>
    {
        public TCBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillnumberID, t.SubName, t.Sub, t.Row, t.ConstFlag });

            // Properties
            this.Property(t => t.BillnumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PtypeID)
                .HasMaxLength(50);

            this.Property(t => t.EtypeID)
                .HasMaxLength(50);

            this.Property(t => t.SubName)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Sub)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Row)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ConstFlag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TCBill");
            this.Property(t => t.BillnumberID).HasColumnName("BillnumberID");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
            this.Property(t => t.SubName).HasColumnName("SubName");
            this.Property(t => t.Sub).HasColumnName("Sub");
            this.Property(t => t.Row).HasColumnName("Row");
            this.Property(t => t.ConstFlag).HasColumnName("ConstFlag");
        }
    }
}
