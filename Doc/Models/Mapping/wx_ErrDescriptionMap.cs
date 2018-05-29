using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class wx_ErrDescriptionMap : EntityTypeConfiguration<wx_ErrDescription>
    {
        public wx_ErrDescriptionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ErrCode)
                .HasMaxLength(100);

            this.Property(t => t.ErrName)
                .HasMaxLength(100);

            this.Property(t => t.ErrPyCode)
                .HasMaxLength(100);

            this.Property(t => t.ErrDes)
                .HasMaxLength(100);

            this.Property(t => t.ErrDeal)
                .HasMaxLength(256);

            this.Property(t => t.ErrComment)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("wx_ErrDescription");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ErrCode).HasColumnName("ErrCode");
            this.Property(t => t.ErrName).HasColumnName("ErrName");
            this.Property(t => t.ErrPyCode).HasColumnName("ErrPyCode");
            this.Property(t => t.ErrDes).HasColumnName("ErrDes");
            this.Property(t => t.ErrDeal).HasColumnName("ErrDeal");
            this.Property(t => t.ErrComment).HasColumnName("ErrComment");
            this.Property(t => t.Total).HasColumnName("Total");
        }
    }
}
