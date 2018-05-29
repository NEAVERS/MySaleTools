using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BillHeadControlFieldMap : EntityTypeConfiguration<BillHeadControlField>
    {
        public BillHeadControlFieldMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.NameField });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.NameField)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .HasMaxLength(200);

            this.Property(t => t.BillType)
                .HasMaxLength(10);

            this.Property(t => t.tabtype)
                .HasMaxLength(100);

            this.Property(t => t.isShow)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("BillHeadControlField");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.NameField).HasColumnName("NameField");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.num).HasColumnName("num");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.tabtype).HasColumnName("tabtype");
            this.Property(t => t.isShow).HasColumnName("isShow");
        }
    }
}
