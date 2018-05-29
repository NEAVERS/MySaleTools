using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_SubsidiaryEquipmentMap : EntityTypeConfiguration<Ac_SubsidiaryEquipment>
    {
        public Ac_SubsidiaryEquipmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FullName)
                .HasMaxLength(200);

            this.Property(t => t.Size)
                .HasMaxLength(200);

            this.Property(t => t.Units)
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Ac_SubsidiaryEquipment");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.Size).HasColumnName("Size");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Units).HasColumnName("Units");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.UseDate).HasColumnName("UseDate");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
