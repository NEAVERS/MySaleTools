using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BillAtypeMap : EntityTypeConfiguration<BillAtype>
    {
        public BillAtypeMap()
        {
            // Primary Key
            this.HasKey(t => t.BillAtypeId);

            // Properties
            this.Property(t => t.BillTypeId)
                .HasMaxLength(50);

            this.Property(t => t.AtypeId)
                .HasMaxLength(50);

            this.Property(t => t.StypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BillAtype");
            this.Property(t => t.BillAtypeId).HasColumnName("BillAtypeId");
            this.Property(t => t.BillTypeId).HasColumnName("BillTypeId");
            this.Property(t => t.AtypeId).HasColumnName("AtypeId");
            this.Property(t => t.StypeId).HasColumnName("StypeId");
        }
    }
}
