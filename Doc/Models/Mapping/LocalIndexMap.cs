using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class LocalIndexMap : EntityTypeConfiguration<LocalIndex>
    {
        public LocalIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberID, t.BillType, t.BillCode, t.BillDate, t.RedWord, t.Draft });

            // Properties
            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.KTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.IfCheck)
                .HasMaxLength(25);

            this.Property(t => t.BCode)
                .HasMaxLength(25);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.Explain)
                .HasMaxLength(256);

            this.Property(t => t.RedWord)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Assessor)
                .HasMaxLength(50);

            this.Property(t => t.ETypeID1)
                .HasMaxLength(50);

            this.Property(t => t.EtypeID2)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LocalIndex");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.KTypeID).HasColumnName("KTypeID");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.IfCheck).HasColumnName("IfCheck");
            this.Property(t => t.TotalQty).HasColumnName("TotalQty");
            this.Property(t => t.BID).HasColumnName("BID");
            this.Property(t => t.BCode).HasColumnName("BCode");
            this.Property(t => t.Period).HasColumnName("Period");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Explain).HasColumnName("Explain");
            this.Property(t => t.RedWord).HasColumnName("RedWord");
            this.Property(t => t.Draft).HasColumnName("Draft");
            this.Property(t => t.Assessor).HasColumnName("Assessor");
            this.Property(t => t.ETypeID1).HasColumnName("ETypeID1");
            this.Property(t => t.EtypeID2).HasColumnName("EtypeID2");
        }
    }
}
