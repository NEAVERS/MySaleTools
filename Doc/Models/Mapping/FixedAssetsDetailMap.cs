using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class FixedAssetsDetailMap : EntityTypeConfiguration<FixedAssetsDetail>
    {
        public FixedAssetsDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BillNumberID)
                .HasMaxLength(100);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .HasMaxLength(200);

            this.Property(t => t.panbarcode)
                .HasMaxLength(200);

            this.Property(t => t.comment)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("FixedAssetsDetails");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.AssertsCardId).HasColumnName("AssertsCardId");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.barcode).HasColumnName("barcode");
            this.Property(t => t.acstate).HasColumnName("acstate");
            this.Property(t => t.panbarcode).HasColumnName("panbarcode");
            this.Property(t => t.panstate).HasColumnName("panstate");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
