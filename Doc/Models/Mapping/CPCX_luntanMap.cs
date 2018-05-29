using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CPCX_luntanMap : EntityTypeConfiguration<CPCX_luntan>
    {
        public CPCX_luntanMap()
        {
            // Primary Key
            this.HasKey(t => t.UserCode);

            // Properties
            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.FullName)
                .HasMaxLength(60);

            this.Property(t => t.Name)
                .HasMaxLength(20);

            this.Property(t => t.Standard)
                .HasMaxLength(20);

            this.Property(t => t.Type)
                .HasMaxLength(20);

            this.Property(t => t.Area)
                .HasMaxLength(20);

            this.Property(t => t.Unit)
                .HasMaxLength(8);

            this.Property(t => t.Manufacturer)
                .HasMaxLength(40);

            this.Property(t => t.FileType)
                .HasMaxLength(100);

            this.Property(t => t.FileName)
                .HasMaxLength(100);

            this.Property(t => t.szDate)
                .HasMaxLength(20);

            this.Property(t => t.OpeatorID)
                .HasMaxLength(50);

            this.Property(t => t.FJContentType)
                .HasMaxLength(100);

            this.Property(t => t.FJFileName)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("CPCX_luntan");
            this.Property(t => t.New_Number).HasColumnName("New_Number");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Standard).HasColumnName("Standard");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.Manufacturer).HasColumnName("Manufacturer");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.ImageFile).HasColumnName("ImageFile");
            this.Property(t => t.FileType).HasColumnName("FileType");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.FileLength).HasColumnName("FileLength");
            this.Property(t => t.szDate).HasColumnName("szDate");
            this.Property(t => t.OpeatorID).HasColumnName("OpeatorID");
            this.Property(t => t.ClickNum).HasColumnName("ClickNum");
            this.Property(t => t.FJBinaryContent).HasColumnName("FJBinaryContent");
            this.Property(t => t.FJContentType).HasColumnName("FJContentType");
            this.Property(t => t.FJContentLength).HasColumnName("FJContentLength");
            this.Property(t => t.FJFileName).HasColumnName("FJFileName");
        }
    }
}
