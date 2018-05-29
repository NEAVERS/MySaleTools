using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BillOperateLogMap : EntityTypeConfiguration<BillOperateLog>
    {
        public BillOperateLogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.BillCode, t.ifcheck, t.btypeid, t.billtype });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.OperateType)
                .HasMaxLength(50);

            this.Property(t => t.EtypeID)
                .HasMaxLength(50);

            this.Property(t => t.IP)
                .HasMaxLength(50);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ifcheck)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.btypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.billtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BillOperateLog");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BillnumberID).HasColumnName("BillnumberID");
            this.Property(t => t.OperateType).HasColumnName("OperateType");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
            this.Property(t => t.OperateTime).HasColumnName("OperateTime");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.ifcheck).HasColumnName("ifcheck");
            this.Property(t => t.btypeid).HasColumnName("btypeid");
            this.Property(t => t.NTotalMoney).HasColumnName("NTotalMoney");
            this.Property(t => t.billtype).HasColumnName("billtype");
        }
    }
}
