using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class nVipAdjustMap : EntityTypeConfiguration<nVipAdjust>
    {
        public nVipAdjustMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberId);

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillCode)
                .HasMaxLength(2000);

            this.Property(t => t.ETypeId)
                .HasMaxLength(100);

            this.Property(t => t.Checke)
                .HasMaxLength(100);

            this.Property(t => t.VipNo)
                .HasMaxLength(200);

            this.Property(t => t.Reason)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("nVipAdjust");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.Checke).HasColumnName("Checke");
            this.Property(t => t.VipNo).HasColumnName("VipNo");
            this.Property(t => t.UpCost).HasColumnName("UpCost");
            this.Property(t => t.DownCost).HasColumnName("DownCost");
            this.Property(t => t.SumCost).HasColumnName("SumCost");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.IsSend).HasColumnName("IsSend");
            this.Property(t => t.nType).HasColumnName("nType");
        }
    }
}
