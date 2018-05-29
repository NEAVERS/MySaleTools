using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_MoneyBillMap : EntityTypeConfiguration<vWeb_MoneyBill>
    {
        public vWeb_MoneyBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberID, t.UserCode, t.FullName, t.ID });

            // Properties
            this.Property(t => t.BillComment)
                .HasMaxLength(256);

            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ATypeID)
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(26);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vWeb_MoneyBill");
            this.Property(t => t.BillComment).HasColumnName("BillComment");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.ATypeID).HasColumnName("ATypeID");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
