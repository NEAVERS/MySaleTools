using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_AssetsModifyRecordsMap : EntityTypeConfiguration<Ac_AssetsModifyRecords>
    {
        public Ac_AssetsModifyRecordsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.OldDTypeId)
                .HasMaxLength(50);

            this.Property(t => t.DTypeId)
                .HasMaxLength(50);

            this.Property(t => t.OldDisATypeId)
                .HasMaxLength(50);

            this.Property(t => t.DisATypeId)
                .HasMaxLength(50);

            this.Property(t => t.ETypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_AssetsModifyRecords");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.OldDTypeId).HasColumnName("OldDTypeId");
            this.Property(t => t.DTypeId).HasColumnName("DTypeId");
            this.Property(t => t.OldLocationId).HasColumnName("OldLocationId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.OldDisATypeId).HasColumnName("OldDisATypeId");
            this.Property(t => t.DisATypeId).HasColumnName("DisATypeId");
            this.Property(t => t.BusinessDate).HasColumnName("BusinessDate");
            this.Property(t => t.OperationDate).HasColumnName("OperationDate");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
        }
    }
}
