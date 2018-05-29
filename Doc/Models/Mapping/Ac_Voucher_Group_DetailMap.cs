using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Voucher_Group_DetailMap : EntityTypeConfiguration<Ac_Voucher_Group_Detail>
    {
        public Ac_Voucher_Group_DetailMap()
        {
            // Primary Key
            this.HasKey(t => t.VgdId);

            // Properties
            this.Property(t => t.ATypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_Voucher_Group_Detail");
            this.Property(t => t.VgdId).HasColumnName("VgdId");
            this.Property(t => t.VgId).HasColumnName("VgId");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.IsDebit).HasColumnName("IsDebit");
            this.Property(t => t.IsCredit).HasColumnName("IsCredit");
            this.Property(t => t.IsDebitOrCredit).HasColumnName("IsDebitOrCredit");
            this.Property(t => t.IsNoDebit).HasColumnName("IsNoDebit");
            this.Property(t => t.IsNoCredit).HasColumnName("IsNoCredit");
            this.Property(t => t.IsNoDebitAndCredit).HasColumnName("IsNoDebitAndCredit");
        }
    }
}
