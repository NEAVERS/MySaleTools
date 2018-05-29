using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_BackingOut_BillMap : EntityTypeConfiguration<Qp_BackingOut_Bill>
    {
        public Qp_BackingOut_BillMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberId);

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BackingOutReason)
                .HasMaxLength(2000);

            this.Property(t => t.BackingOutCheck)
                .HasMaxLength(2000);

            this.Property(t => t.BackingOutResult)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Qp_BackingOut_Bill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BackingOutReason).HasColumnName("BackingOutReason");
            this.Property(t => t.BackingOutCheck).HasColumnName("BackingOutCheck");
            this.Property(t => t.BackingOutResult).HasColumnName("BackingOutResult");
            this.Property(t => t.BackingOutState).HasColumnName("BackingOutState");
        }
    }
}
