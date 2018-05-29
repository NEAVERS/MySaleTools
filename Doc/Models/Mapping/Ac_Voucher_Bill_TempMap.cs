using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Voucher_Bill_TempMap : EntityTypeConfiguration<Ac_Voucher_Bill_Temp>
    {
        public Ac_Voucher_Bill_TempMap()
        {
            // Primary Key
            this.HasKey(t => new { t.explain, t.STypeId });

            // Properties
            this.Property(t => t.explain)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.usercode)
                .HasMaxLength(500);

            this.Property(t => t.fullname)
                .HasMaxLength(500);

            this.Property(t => t.typeid)
                .HasMaxLength(50);

            this.Property(t => t.FSettleNo)
                .HasMaxLength(200);

            this.Property(t => t.comment)
                .HasMaxLength(500);

            this.Property(t => t.STypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MainItems)
                .HasMaxLength(500);

            this.Property(t => t.AdditionItems)
                .HasMaxLength(500);

            this.Property(t => t.mainitemsid)
                .HasMaxLength(500);

            this.Property(t => t.additionitemsid)
                .HasMaxLength(500);

            this.Property(t => t.mainitemsname)
                .HasMaxLength(500);

            this.Property(t => t.additionitemsname)
                .HasMaxLength(500);

            this.Property(t => t.assist)
                .HasMaxLength(5000);

            this.Property(t => t.asslist)
                .HasMaxLength(5000);

            this.Property(t => t.balancenum)
                .HasMaxLength(500);

            this.Property(t => t.cUserCode)
                .HasMaxLength(500);

            this.Property(t => t.cFullName)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Ac_Voucher_Bill_Temp");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.explain).HasColumnName("explain");
            this.Property(t => t.usercode).HasColumnName("usercode");
            this.Property(t => t.fullname).HasColumnName("fullname");
            this.Property(t => t.typeid).HasColumnName("typeid");
            this.Property(t => t.sysrow).HasColumnName("sysrow");
            this.Property(t => t.cid).HasColumnName("cid");
            this.Property(t => t.moneytype).HasColumnName("moneytype");
            this.Property(t => t.basisType).HasColumnName("basisType");
            this.Property(t => t.rate).HasColumnName("rate");
            this.Property(t => t.balanceprice).HasColumnName("balanceprice");
            this.Property(t => t.lendprice).HasColumnName("lendprice");
            this.Property(t => t.loanprice).HasColumnName("loanprice");
            this.Property(t => t.FSettleNo).HasColumnName("FSettleNo");
            this.Property(t => t.FSettleTypeID).HasColumnName("FSettleTypeID");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.Fdc).HasColumnName("Fdc");
            this.Property(t => t.fadc).HasColumnName("fadc");
            this.Property(t => t.facnt).HasColumnName("facnt");
            this.Property(t => t.FCashFlowItem).HasColumnName("FCashFlowItem");
            this.Property(t => t.rowno).HasColumnName("rowno");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.MainItems).HasColumnName("MainItems");
            this.Property(t => t.AdditionItems).HasColumnName("AdditionItems");
            this.Property(t => t.KeyId).HasColumnName("KeyId");
            this.Property(t => t.iscash).HasColumnName("iscash");
            this.Property(t => t.isbank).HasColumnName("isbank");
            this.Property(t => t.IsDiary).HasColumnName("IsDiary");
            this.Property(t => t.isother).HasColumnName("isother");
            this.Property(t => t.mcid).HasColumnName("mcid");
            this.Property(t => t.mainitemsid).HasColumnName("mainitemsid");
            this.Property(t => t.additionitemsid).HasColumnName("additionitemsid");
            this.Property(t => t.mainitemsname).HasColumnName("mainitemsname");
            this.Property(t => t.additionitemsname).HasColumnName("additionitemsname");
            this.Property(t => t.assist).HasColumnName("assist");
            this.Property(t => t.asslist).HasColumnName("asslist");
            this.Property(t => t.balancenum).HasColumnName("balancenum");
            this.Property(t => t.balancetype).HasColumnName("balancetype");
            this.Property(t => t.cUserCode).HasColumnName("cUserCode");
            this.Property(t => t.cFullName).HasColumnName("cFullName");
            this.Property(t => t.islimit_ac).HasColumnName("islimit_ac");
        }
    }
}
