using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CapitalTransfer_BillMap : EntityTypeConfiguration<CapitalTransfer_Bill>
    {
        public CapitalTransfer_BillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.BillNumberId, t.BankAccountOut, t.BankAccountIn });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BankAccountOut)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BankAccountIn)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("CapitalTransfer_Bill");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BankAccountOut).HasColumnName("BankAccountOut");
            this.Property(t => t.BankAccountIn).HasColumnName("BankAccountIn");
            this.Property(t => t.TransferPrice).HasColumnName("TransferPrice");
            this.Property(t => t.DeductPrice).HasColumnName("DeductPrice");
            this.Property(t => t.NTransferPrice).HasColumnName("NTransferPrice");
            this.Property(t => t.NDeductPrice).HasColumnName("NDeductPrice");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
