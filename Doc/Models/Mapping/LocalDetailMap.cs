using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class LocalDetailMap : EntityTypeConfiguration<LocalDetail>
    {
        public LocalDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.BillNumberID, t.BillType });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PTypeID)
                .HasMaxLength(50);

            this.Property(t => t.LTypeID)
                .HasMaxLength(25);

            this.Property(t => t.LTypeID2)
                .HasMaxLength(25);

            this.Property(t => t.Comment)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("LocalDetail");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.LTypeID).HasColumnName("LTypeID");
            this.Property(t => t.LTypeID2).HasColumnName("LTypeID2");
            this.Property(t => t.QTY).HasColumnName("QTY");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.TeamNo1).HasColumnName("TeamNo1");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
