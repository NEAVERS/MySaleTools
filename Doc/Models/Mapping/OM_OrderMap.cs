using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_OrderMap : EntityTypeConfiguration<OM_Order>
    {
        public OM_OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.SerialNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BtypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BtypeName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreatorName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ModifierName)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("OM_Order");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.SerialNo).HasColumnName("SerialNo");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.TotalMoney).HasColumnName("TotalMoney");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.BtypeId).HasColumnName("BtypeId");
            this.Property(t => t.BtypeName).HasColumnName("BtypeName");
            this.Property(t => t.CreatorId).HasColumnName("CreatorId");
            this.Property(t => t.CreatorName).HasColumnName("CreatorName");
            this.Property(t => t.CreatedTime).HasColumnName("CreatedTime");
            this.Property(t => t.ModifierId).HasColumnName("ModifierId");
            this.Property(t => t.ModifierName).HasColumnName("ModifierName");
            this.Property(t => t.ModifiedTime).HasColumnName("ModifiedTime");
            this.Property(t => t.PreferenceMoney).HasColumnName("PreferenceMoney");
            this.Property(t => t.bid).HasColumnName("bid");
        }
    }
}
