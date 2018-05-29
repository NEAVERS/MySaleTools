using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_SuccorBill_ErrDescriptionMap : EntityTypeConfiguration<Qp_SuccorBill_ErrDescription>
    {
        public Qp_SuccorBill_ErrDescriptionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Comment)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Qp_SuccorBill_ErrDescription");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
