using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class VipCardSetMap : EntityTypeConfiguration<VipCardSet>
    {
        public VipCardSetMap()
        {
            // Primary Key
            this.HasKey(t => t.VipCardID);

            // Properties
            this.Property(t => t.VipCardName)
                .HasMaxLength(200);

            this.Property(t => t.Note)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("VipCardSet");
            this.Property(t => t.VipCardID).HasColumnName("VipCardID");
            this.Property(t => t.VipCardName).HasColumnName("VipCardName");
            this.Property(t => t.VipCardKL).HasColumnName("VipCardKL");
            this.Property(t => t.VipCardAutoZK).HasColumnName("VipCardAutoZK");
            this.Property(t => t.ConsumeMoney).HasColumnName("ConsumeMoney");
            this.Property(t => t.ConsumeTimes).HasColumnName("ConsumeTimes");
            this.Property(t => t.TimeLimit).HasColumnName("TimeLimit");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.VipCardKz).HasColumnName("VipCardKz");
        }
    }
}
