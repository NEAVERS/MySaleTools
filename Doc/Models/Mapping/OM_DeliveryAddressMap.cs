using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_DeliveryAddressMap : EntityTypeConfiguration<OM_DeliveryAddress>
    {
        public OM_DeliveryAddressMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .HasMaxLength(500);

            this.Property(t => t.PhoneNumber)
                .HasMaxLength(50);

            this.Property(t => t.TelPhone)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.CreatorName)
                .HasMaxLength(200);

            this.Property(t => t.ModifierName)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("OM_DeliveryAddress");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.TelPhone).HasColumnName("TelPhone");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.CreatorId).HasColumnName("CreatorId");
            this.Property(t => t.CreatorName).HasColumnName("CreatorName");
            this.Property(t => t.CreatedTime).HasColumnName("CreatedTime");
            this.Property(t => t.ModifierId).HasColumnName("ModifierId");
            this.Property(t => t.ModifierName).HasColumnName("ModifierName");
            this.Property(t => t.ModifiedTime).HasColumnName("ModifiedTime");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
        }
    }
}
