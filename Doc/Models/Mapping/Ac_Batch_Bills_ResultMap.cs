using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Batch_Bills_ResultMap : EntityTypeConfiguration<Ac_Batch_Bills_Result>
    {
        public Ac_Batch_Bills_ResultMap()
        {
            // Primary Key
            this.HasKey(t => t.Nid);

            // Properties
            this.Property(t => t.BillCode)
                .HasMaxLength(500);

            this.Property(t => t.Msg)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Ac_Batch_Bills_Result");
            this.Property(t => t.Nid).HasColumnName("Nid");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.Msg).HasColumnName("Msg");
        }
    }
}
