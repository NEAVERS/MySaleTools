using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class LoginUserColMap : EntityTypeConfiguration<LoginUserCol>
    {
        public LoginUserColMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ETypeID, t.BillType, t.ColDataField, t.Display });

            // Properties
            this.Property(t => t.ETypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ColDataField)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Display)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("LoginUserCol");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.ColDataField).HasColumnName("ColDataField");
            this.Property(t => t.Display).HasColumnName("Display");
        }
    }
}
