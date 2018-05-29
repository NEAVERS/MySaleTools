using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BillIndexMap : EntityTypeConfiguration<BillIndex>
    {
        public BillIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.BillDate, t.BillCode, t.BillType, t.RedWord, t.draft, t.Uploaded, t.ID, t.PrePriceNum, t.PromoRuleId, t.BeforePromoBillNumberId, t.ImportType, t.PromotionMsg, t.DeliveryAddress, t.AddDTypeETypeType, t.CWCheck, t.IfConfirm, t.TransferType, t.FeeDeductType, t.AdPriceType, t.ChargeOffType });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.atypeid)
                .HasMaxLength(50);

            this.Property(t => t.ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.btypeid)
                .HasMaxLength(50);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.ktypeid)
                .HasMaxLength(50);

            this.Property(t => t.ktypeid2)
                .HasMaxLength(50);

            this.Property(t => t.ifcheck)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.checke)
                .HasMaxLength(50);

            this.Property(t => t.explain)
                .HasMaxLength(256);

            this.Property(t => t.RedWord)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.waybillcode)
                .HasMaxLength(50);

            this.Property(t => t.goodsnumber)
                .HasMaxLength(20);

            this.Property(t => t.packway)
                .HasMaxLength(20);

            this.Property(t => t.TEL)
                .HasMaxLength(100);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Assessor)
                .HasMaxLength(50);

            this.Property(t => t.IfAudit)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Audit_explain)
                .HasMaxLength(256);

            this.Property(t => t.IfStopMoney)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DTypeId)
                .HasMaxLength(50);

            this.Property(t => t.jsStyle)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.jsState)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.KTypeID3)
                .HasMaxLength(50);

            this.Property(t => t.LinkMan)
                .HasMaxLength(256);

            this.Property(t => t.LinkTel)
                .HasMaxLength(256);

            this.Property(t => t.LinkAddr)
                .HasMaxLength(256);

            this.Property(t => t.wxManID)
                .HasMaxLength(50);

            this.Property(t => t.BuyDate)
                .HasMaxLength(50);

            this.Property(t => t.Serial)
                .HasMaxLength(200);

            this.Property(t => t.ErrDes)
                .HasMaxLength(3000);

            this.Property(t => t.Poster)
                .HasMaxLength(50);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.updateE)
                .HasMaxLength(50);

            this.Property(t => t.TransportId)
                .HasMaxLength(10);

            this.Property(t => t.ATypeID1)
                .HasMaxLength(50);

            this.Property(t => t.RedReason)
                .HasMaxLength(500);

            this.Property(t => t.PrePriceNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PromoRuleId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BeforePromoBillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PromotionMsg)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Reconciliation)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DeliveryAddress)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.AddDTypeETypeType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillTime)
                .HasMaxLength(20);

            this.Property(t => t.CWCheck)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FreightAddr)
                .HasMaxLength(300);

            this.Property(t => t.FreightPerson)
                .HasMaxLength(100);

            this.Property(t => t.FreightTel)
                .HasMaxLength(100);

            this.Property(t => t.UF1)
                .HasMaxLength(200);

            this.Property(t => t.UF2)
                .HasMaxLength(200);

            this.Property(t => t.UF3)
                .HasMaxLength(200);

            this.Property(t => t.UF4)
                .HasMaxLength(200);

            this.Property(t => t.UF5)
                .HasMaxLength(200);

            this.Property(t => t.DealBTypeID)
                .HasMaxLength(50);

            this.Property(t => t.TallyId)
                .HasMaxLength(50);

            this.Property(t => t.StypeID2)
                .HasMaxLength(50);

            this.Property(t => t.IfConfirm)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TransferType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FeeDeductType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ChargeOffBtypeid)
                .HasMaxLength(50);

            this.Property(t => t.ChargeOffType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cwchecker)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BillIndex");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.atypeid).HasColumnName("atypeid");
            this.Property(t => t.ptypeid).HasColumnName("ptypeid");
            this.Property(t => t.btypeid).HasColumnName("btypeid");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.ktypeid).HasColumnName("ktypeid");
            this.Property(t => t.ktypeid2).HasColumnName("ktypeid2");
            this.Property(t => t.ifcheck).HasColumnName("ifcheck");
            this.Property(t => t.checke).HasColumnName("checke");
            this.Property(t => t.totalmoney).HasColumnName("totalmoney");
            this.Property(t => t.totalinmoney).HasColumnName("totalinmoney");
            this.Property(t => t.totalqty).HasColumnName("totalqty");
            this.Property(t => t.tax).HasColumnName("tax");
            this.Property(t => t.period).HasColumnName("period");
            this.Property(t => t.explain).HasColumnName("explain");
            this.Property(t => t.RedWord).HasColumnName("RedWord");
            this.Property(t => t.draft).HasColumnName("draft");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.waybillcode).HasColumnName("waybillcode");
            this.Property(t => t.goodsnumber).HasColumnName("goodsnumber");
            this.Property(t => t.packway).HasColumnName("packway");
            this.Property(t => t.TEL).HasColumnName("TEL");
            this.Property(t => t.Uploaded).HasColumnName("Uploaded");
            this.Property(t => t.OFF_ID).HasColumnName("OFF_ID");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.AlertDay).HasColumnName("AlertDay");
            this.Property(t => t.CompleteTotal).HasColumnName("CompleteTotal");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Assessor).HasColumnName("Assessor");
            this.Property(t => t.IfAudit).HasColumnName("IfAudit");
            this.Property(t => t.Audit_explain).HasColumnName("Audit_explain");
            this.Property(t => t.IfStopMoney).HasColumnName("IfStopMoney");
            this.Property(t => t.preferencemoney).HasColumnName("preferencemoney");
            this.Property(t => t.DTypeId).HasColumnName("DTypeId");
            this.Property(t => t.JF).HasColumnName("JF");
            this.Property(t => t.VipCardID).HasColumnName("VipCardID");
            this.Property(t => t.vipCZMoney).HasColumnName("vipCZMoney");
            this.Property(t => t.jsStyle).HasColumnName("jsStyle");
            this.Property(t => t.jsState).HasColumnName("jsState");
            this.Property(t => t.KTypeID3).HasColumnName("KTypeID3");
            this.Property(t => t.LinkMan).HasColumnName("LinkMan");
            this.Property(t => t.LinkTel).HasColumnName("LinkTel");
            this.Property(t => t.LinkAddr).HasColumnName("LinkAddr");
            this.Property(t => t.wxManID).HasColumnName("wxManID");
            this.Property(t => t.JieJianBillNumberID).HasColumnName("JieJianBillNumberID");
            this.Property(t => t.JieJianID).HasColumnName("JieJianID");
            this.Property(t => t.JieJianState).HasColumnName("JieJianState");
            this.Property(t => t.BaoXiuBillNumberID).HasColumnName("BaoXiuBillNumberID");
            this.Property(t => t.BaoXiuID).HasColumnName("BaoXiuID");
            this.Property(t => t.BuyDate).HasColumnName("BuyDate");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.wxTotal).HasColumnName("wxTotal");
            this.Property(t => t.ErrDes).HasColumnName("ErrDes");
            this.Property(t => t.ifHideJieJian).HasColumnName("ifHideJieJian");
            this.Property(t => t.ifWX).HasColumnName("ifWX");
            this.Property(t => t.ifYearBill).HasColumnName("ifYearBill");
            this.Property(t => t.Poster).HasColumnName("Poster");
            this.Property(t => t.LastUpdateTime).HasColumnName("LastUpdateTime");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.FromBillNumberID).HasColumnName("FromBillNumberID");
            this.Property(t => t.CostSale).HasColumnName("CostSale");
            this.Property(t => t.OtherInOutType).HasColumnName("OtherInOutType");
            this.Property(t => t.PosBillType).HasColumnName("PosBillType");
            this.Property(t => t.checkTime).HasColumnName("checkTime");
            this.Property(t => t.posttime).HasColumnName("posttime");
            this.Property(t => t.updateE).HasColumnName("updateE");
            this.Property(t => t.ShareMode).HasColumnName("ShareMode");
            this.Property(t => t.TransportId).HasColumnName("TransportId");
            this.Property(t => t.IsIni).HasColumnName("IsIni");
            this.Property(t => t.ATypeID1).HasColumnName("ATypeID1");
            this.Property(t => t.NCompleteTotal).HasColumnName("NCompleteTotal");
            this.Property(t => t.ATID).HasColumnName("ATID");
            this.Property(t => t.IfCargo).HasColumnName("IfCargo");
            this.Property(t => t.InvoiceMoney).HasColumnName("InvoiceMoney");
            this.Property(t => t.NInvoiceMoney).HasColumnName("NInvoiceMoney");
            this.Property(t => t.NARTotal).HasColumnName("NARTotal");
            this.Property(t => t.NAPTotal).HasColumnName("NAPTotal");
            this.Property(t => t.NYSTotal).HasColumnName("NYSTotal");
            this.Property(t => t.NYFTotal).HasColumnName("NYFTotal");
            this.Property(t => t.RedReason).HasColumnName("RedReason");
            this.Property(t => t.PrePriceNum).HasColumnName("PrePriceNum");
            this.Property(t => t.AssetBusinessTypeId).HasColumnName("AssetBusinessTypeId");
            this.Property(t => t.PromoRuleId).HasColumnName("PromoRuleId");
            this.Property(t => t.BeforePromoBillNumberId).HasColumnName("BeforePromoBillNumberId");
            this.Property(t => t.ImportType).HasColumnName("ImportType");
            this.Property(t => t.NewPosBill).HasColumnName("NewPosBill");
            this.Property(t => t.PromotionMsg).HasColumnName("PromotionMsg");
            this.Property(t => t.Reconciliation).HasColumnName("Reconciliation");
            this.Property(t => t.ARTOTAL).HasColumnName("ARTOTAL");
            this.Property(t => t.APTOTAL).HasColumnName("APTOTAL");
            this.Property(t => t.YSTOTAL).HasColumnName("YSTOTAL");
            this.Property(t => t.YFTOTAL).HasColumnName("YFTOTAL");
            this.Property(t => t.IsAuto).HasColumnName("IsAuto");
            this.Property(t => t.IsYapi).HasColumnName("IsYapi");
            this.Property(t => t.YapiOrderID).HasColumnName("YapiOrderID");
            this.Property(t => t.DeliveryAddress).HasColumnName("DeliveryAddress");
            this.Property(t => t.AddDTypeETypeType).HasColumnName("AddDTypeETypeType");
            this.Property(t => t.BillTime).HasColumnName("BillTime");
            this.Property(t => t.CWCheck).HasColumnName("CWCheck");
            this.Property(t => t.IfBargainOn).HasColumnName("IfBargainOn");
            this.Property(t => t.IfMulAccount).HasColumnName("IfMulAccount");
            this.Property(t => t.IsFreightMoney).HasColumnName("IsFreightMoney");
            this.Property(t => t.FreightAddr).HasColumnName("FreightAddr");
            this.Property(t => t.FreightPerson).HasColumnName("FreightPerson");
            this.Property(t => t.FreightTel).HasColumnName("FreightTel");
            this.Property(t => t.IfInvoice).HasColumnName("IfInvoice");
            this.Property(t => t.UF1).HasColumnName("UF1");
            this.Property(t => t.UF2).HasColumnName("UF2");
            this.Property(t => t.UF3).HasColumnName("UF3");
            this.Property(t => t.UF4).HasColumnName("UF4");
            this.Property(t => t.UF5).HasColumnName("UF5");
            this.Property(t => t.DealBTypeID).HasColumnName("DealBTypeID");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.NTotalMoney).HasColumnName("NTotalMoney");
            this.Property(t => t.NTotalInMoney).HasColumnName("NTotalInMoney");
            this.Property(t => t.NPreferenceMoney).HasColumnName("NPreferenceMoney");
            this.Property(t => t.NVIPCZMoney).HasColumnName("NVIPCZMoney");
            this.Property(t => t.billproperty).HasColumnName("billproperty");
            this.Property(t => t.TallyId).HasColumnName("TallyId");
            this.Property(t => t.StypeID2).HasColumnName("StypeID2");
            this.Property(t => t.IfConfirm).HasColumnName("IfConfirm");
            this.Property(t => t.TransferType).HasColumnName("TransferType");
            this.Property(t => t.FeeDeductType).HasColumnName("FeeDeductType");
            this.Property(t => t.IsLend).HasColumnName("IsLend");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.AdPriceType).HasColumnName("AdPriceType");
            this.Property(t => t.ChargeOffBtypeid).HasColumnName("ChargeOffBtypeid");
            this.Property(t => t.ChargeOffType).HasColumnName("ChargeOffType");
            this.Property(t => t.ChargeOffTotal).HasColumnName("ChargeOffTotal");
            this.Property(t => t.NChargeOffTotal).HasColumnName("NChargeOffTotal");
            this.Property(t => t.cwchecker).HasColumnName("cwchecker");
        }
    }
}
