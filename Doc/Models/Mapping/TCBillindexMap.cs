using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class TCBillindexMap : EntityTypeConfiguration<TCBillindex>
    {
        public TCBillindexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillnumberID, t.BillDate, t.BillCode, t.StartDate, t.EndDate });

            // Properties
            this.Property(t => t.BillnumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.checke)
                .HasMaxLength(50);

            this.Property(t => t.EtypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TCBillindex");
            this.Property(t => t.BillnumberID).HasColumnName("BillnumberID");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.checke).HasColumnName("checke");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
        }
    }
}
