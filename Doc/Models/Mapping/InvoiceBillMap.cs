using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class InvoiceBillMap : EntityTypeConfiguration<InvoiceBill>
    {
        public InvoiceBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberID, t.IfInVoice, t.ETypeID, t.InvoiceStyle, t.isDraft, t.InvoiceID });

            // Properties
            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IfInVoice)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ETypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvoiceStyle)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Explain)
                .HasMaxLength(256);

            this.Property(t => t.InvoiceNo)
                .HasMaxLength(50);

            this.Property(t => t.InvoiceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("InvoiceBill");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.IfInVoice).HasColumnName("IfInVoice");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.InvoiceStyle).HasColumnName("InvoiceStyle");
            this.Property(t => t.InvoiceTotal).HasColumnName("InvoiceTotal");
            this.Property(t => t.Explain).HasColumnName("Explain");
            this.Property(t => t.InvoiceDate).HasColumnName("InvoiceDate");
            this.Property(t => t.InvoiceNo).HasColumnName("InvoiceNo");
            this.Property(t => t.isDraft).HasColumnName("isDraft");
            this.Property(t => t.InvoiceID).HasColumnName("InvoiceID");
        }
    }
}
