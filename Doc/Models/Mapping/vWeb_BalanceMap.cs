using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_BalanceMap : EntityTypeConfiguration<vWeb_Balance>
    {
        public vWeb_BalanceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillType, t.ktypeid, t.ktypeid2, t.bFullName, t.BillNumberId, t.BillDate, t.BillCode, t.EFullName });

            // Properties
            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.btypeid)
                .HasMaxLength(50);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.ktypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ktypeid2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.bUserCode)
                .HasMaxLength(26);

            this.Property(t => t.bFullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.EFullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.IfStopMoney)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("vWeb_Balance");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.btypeid).HasColumnName("btypeid");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.ktypeid).HasColumnName("ktypeid");
            this.Property(t => t.ktypeid2).HasColumnName("ktypeid2");
            this.Property(t => t.bUserCode).HasColumnName("bUserCode");
            this.Property(t => t.bFullName).HasColumnName("bFullName");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.EFullName).HasColumnName("EFullName");
            this.Property(t => t.unCompleteTotal).HasColumnName("unCompleteTotal");
            this.Property(t => t.preferencemoney).HasColumnName("preferencemoney");
            this.Property(t => t.completetotal).HasColumnName("completetotal");
            this.Property(t => t.totalinmoney).HasColumnName("totalinmoney");
            this.Property(t => t.IfStopMoney).HasColumnName("IfStopMoney");
        }
    }
}
