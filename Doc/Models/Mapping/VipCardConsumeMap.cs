using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class VipCardConsumeMap : EntityTypeConfiguration<VipCardConsume>
    {
        public VipCardConsumeMap()
        {
            // Primary Key
            this.HasKey(t => t.VipCardConsumeId);

            // Properties
            this.Property(t => t.VipCardNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VipCardConsume");
            this.Property(t => t.VipCardConsumeId).HasColumnName("VipCardConsumeId");
            this.Property(t => t.VipCardNo).HasColumnName("VipCardNo");
            this.Property(t => t.PreConsumeDate).HasColumnName("PreConsumeDate");
            this.Property(t => t.PreConsumeMoney).HasColumnName("PreConsumeMoney");
            this.Property(t => t.PreConsumeRate).HasColumnName("PreConsumeRate");
            this.Property(t => t.PreConsumeZkMoney).HasColumnName("PreConsumeZkMoney");
            this.Property(t => t.SumConsumeMoney).HasColumnName("SumConsumeMoney");
            this.Property(t => t.NextZkRate).HasColumnName("NextZkRate");
            this.Property(t => t.SumConsumeZkMoney).HasColumnName("SumConsumeZkMoney");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
        }
    }
}
