using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_AdPriceBillMap : EntityTypeConfiguration<vWeb_AdPriceBill>
    {
        public vWeb_AdPriceBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.IsUnit2, t.ID, t.ktypeid, t.leveal, t.sonnum, t.soncount, t.FullName, t.deleted, t.PosDataVersion, t.IsService, t.SortID, t.Pid });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.base)
                .HasMaxLength(256);

            this.Property(t => t.ProduceDate)
                .HasMaxLength(50);

            this.Property(t => t.ValidDate)
                .HasMaxLength(50);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.PtypeId)
                .HasMaxLength(50);

            this.Property(t => t.IsUnit2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.unit)
                .HasMaxLength(200);

            this.Property(t => t.nunit)
                .HasMaxLength(200);

            this.Property(t => t.cargofullname)
                .HasMaxLength(200);

            this.Property(t => t.ktypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.kfullname)
                .HasMaxLength(66);

            this.Property(t => t.frombillnumberusercode)
                .HasMaxLength(200);

            this.Property(t => t.typeId)
                .HasMaxLength(50);

            this.Property(t => t.ParId)
                .HasMaxLength(50);

            this.Property(t => t.leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sonnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.soncount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CanModify)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Standard)
                .HasMaxLength(200);

            this.Property(t => t.Type)
                .HasMaxLength(200);

            this.Property(t => t.Area)
                .HasMaxLength(200);

            this.Property(t => t.Unit1)
                .HasMaxLength(8);

            this.Property(t => t.Unit2)
                .HasMaxLength(8);

            this.Property(t => t.Comment)
                .HasMaxLength(250);

            this.Property(t => t.EntryCode)
                .HasMaxLength(200);

            this.Property(t => t.IfSerial)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PyCode)
                .HasMaxLength(500);

            this.Property(t => t.DwgNo)
                .HasMaxLength(100);

            this.Property(t => t.ImgURL)
                .HasMaxLength(200);

            this.Property(t => t.PosDataVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            this.Property(t => t.IsService)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SortID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.customitemid)
                .HasMaxLength(20);

            this.Property(t => t.customitemfrom)
                .HasMaxLength(20);

            this.Property(t => t.Pid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SysDiy1)
                .HasMaxLength(500);

            this.Property(t => t.SysDiy2)
                .HasMaxLength(500);

            this.Property(t => t.SysDiy3)
                .HasMaxLength(500);

            this.Property(t => t.SysDiy4)
                .HasMaxLength(500);

            this.Property(t => t.SysDiy5)
                .HasMaxLength(500);

            this.Property(t => t.SysDiy11)
                .HasMaxLength(500);

            this.Property(t => t.SysDiy12)
                .HasMaxLength(500);

            this.Property(t => t.SysDiy13)
                .HasMaxLength(500);

            this.Property(t => t.SysDiy14)
                .HasMaxLength(500);

            this.Property(t => t.SysDiy15)
                .HasMaxLength(500);

            this.Property(t => t.SysDiy16)
                .HasMaxLength(500);

            this.Property(t => t.efullnamecustom)
                .HasMaxLength(66);

            this.Property(t => t.pfullnamecustom)
                .HasMaxLength(200);

            this.Property(t => t.bfullnamecustom)
                .HasMaxLength(66);

            this.Property(t => t.dfullnamecustom)
                .HasMaxLength(100);

            this.Property(t => t.kfullnamecustom)
                .HasMaxLength(66);

            this.Property(t => t.sfullnamecustom)
                .HasMaxLength(66);

            // Table & Column Mappings
            this.ToTable("vWeb_AdPriceBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.base).HasColumnName("base");
            this.Property(t => t.QTY).HasColumnName("QTY");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.beforeprice).HasColumnName("beforeprice");
            this.Property(t => t.NTotal).HasColumnName("NTotal");
            this.Property(t => t.NPrice).HasColumnName("NPrice");
            this.Property(t => t.frombillid).HasColumnName("frombillid");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.beforetotal).HasColumnName("beforetotal");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.GoodsCostPrice).HasColumnName("GoodsCostPrice");
            this.Property(t => t.HandZeroCost).HasColumnName("HandZeroCost");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
            this.Property(t => t.ChangeAllStock).HasColumnName("ChangeAllStock");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.itemname).HasColumnName("itemname");
            this.Property(t => t.iscombined).HasColumnName("iscombined");
            this.Property(t => t.UnitID).HasColumnName("UnitID");
            this.Property(t => t.NUnitID).HasColumnName("NUnitID");
            this.Property(t => t.unit).HasColumnName("unit");
            this.Property(t => t.nunit).HasColumnName("nunit");
            this.Property(t => t.UnitRate).HasColumnName("UnitRate");
            this.Property(t => t.NQty).HasColumnName("NQty");
            this.Property(t => t.cargoID).HasColumnName("cargoID");
            this.Property(t => t.cargofullname).HasColumnName("cargofullname");
            this.Property(t => t.ktypeid).HasColumnName("ktypeid");
            this.Property(t => t.kfullname).HasColumnName("kfullname");
            this.Property(t => t.frombillnumberusercode).HasColumnName("frombillnumberusercode");
            this.Property(t => t.FromBillNumberId).HasColumnName("FromBillNumberId");
            this.Property(t => t.serial).HasColumnName("serial");
            this.Property(t => t.typeId).HasColumnName("typeId");
            this.Property(t => t.ParId).HasColumnName("ParId");
            this.Property(t => t.leveal).HasColumnName("leveal");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.CanModify).HasColumnName("CanModify");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Standard).HasColumnName("Standard");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Unit1).HasColumnName("Unit1");
            this.Property(t => t.Unit2).HasColumnName("Unit2");
            this.Property(t => t.UnitRate1).HasColumnName("UnitRate1");
            this.Property(t => t.UnitRate2).HasColumnName("UnitRate2");
            this.Property(t => t.preprice1).HasColumnName("preprice1");
            this.Property(t => t.preprice2).HasColumnName("preprice2");
            this.Property(t => t.preprice3).HasColumnName("preprice3");
            this.Property(t => t.preprice4).HasColumnName("preprice4");
            this.Property(t => t.preprice5).HasColumnName("preprice5");
            this.Property(t => t.UsefulLifeMonth).HasColumnName("UsefulLifeMonth");
            this.Property(t => t.UsefulLifeDay).HasColumnName("UsefulLifeDay");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.recPrice).HasColumnName("recPrice");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.ColorGroupID).HasColumnName("ColorGroupID");
            this.Property(t => t.SizeGroupID).HasColumnName("SizeGroupID");
            this.Property(t => t.EntryCode).HasColumnName("EntryCode");
            this.Property(t => t.IfSerial).HasColumnName("IfSerial");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.SerialCount).HasColumnName("SerialCount");
            this.Property(t => t.ValidDays).HasColumnName("ValidDays");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.DwgNo).HasColumnName("DwgNo");
            this.Property(t => t.ImgURL).HasColumnName("ImgURL");
            this.Property(t => t.IsDownLoad).HasColumnName("IsDownLoad");
            this.Property(t => t.PosDataVersion).HasColumnName("PosDataVersion");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsService).HasColumnName("IsService");
            this.Property(t => t.SortID).HasColumnName("SortID");
            this.Property(t => t.OmUse).HasColumnName("OmUse");
            this.Property(t => t.OmPrice).HasColumnName("OmPrice");
            this.Property(t => t.BuyDefaultRate).HasColumnName("BuyDefaultRate");
            this.Property(t => t.SaleDefaultRate).HasColumnName("SaleDefaultRate");
            this.Property(t => t.Integral).HasColumnName("Integral");
            this.Property(t => t.StopBuy).HasColumnName("StopBuy");
            this.Property(t => t.IsOm).HasColumnName("IsOm");
            this.Property(t => t.customitemid).HasColumnName("customitemid");
            this.Property(t => t.customitemfrom).HasColumnName("customitemfrom");
            this.Property(t => t.customitemname).HasColumnName("customitemname");
            this.Property(t => t.customitemrefid).HasColumnName("customitemrefid");
            this.Property(t => t.UnitsType).HasColumnName("UnitsType");
            this.Property(t => t.AssistantUnitId).HasColumnName("AssistantUnitId");
            this.Property(t => t.SaleUnitId).HasColumnName("SaleUnitId");
            this.Property(t => t.BuyUnitId).HasColumnName("BuyUnitId");
            this.Property(t => t.ProduceUnitId).HasColumnName("ProduceUnitId");
            this.Property(t => t.StockUnitId).HasColumnName("StockUnitId");
            this.Property(t => t.JobUnitId).HasColumnName("JobUnitId");
            this.Property(t => t.baseUnitId).HasColumnName("baseUnitId");
            this.Property(t => t.IfUseEntryCode).HasColumnName("IfUseEntryCode");
            this.Property(t => t.IfUseGoodsNum).HasColumnName("IfUseGoodsNum");
            this.Property(t => t.Pid).HasColumnName("Pid");
            this.Property(t => t.isyapi).HasColumnName("isyapi");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.Detailid).HasColumnName("Detailid");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.SysDiy1).HasColumnName("SysDiy1");
            this.Property(t => t.SysDiy2).HasColumnName("SysDiy2");
            this.Property(t => t.SysDiy3).HasColumnName("SysDiy3");
            this.Property(t => t.SysDiy4).HasColumnName("SysDiy4");
            this.Property(t => t.SysDiy5).HasColumnName("SysDiy5");
            this.Property(t => t.SysDiy6).HasColumnName("SysDiy6");
            this.Property(t => t.SysDiy7).HasColumnName("SysDiy7");
            this.Property(t => t.SysDiy8).HasColumnName("SysDiy8");
            this.Property(t => t.SysDiy9).HasColumnName("SysDiy9");
            this.Property(t => t.SysDiy10).HasColumnName("SysDiy10");
            this.Property(t => t.SysDiy11).HasColumnName("SysDiy11");
            this.Property(t => t.SysDiy12).HasColumnName("SysDiy12");
            this.Property(t => t.SysDiy13).HasColumnName("SysDiy13");
            this.Property(t => t.SysDiy14).HasColumnName("SysDiy14");
            this.Property(t => t.SysDiy15).HasColumnName("SysDiy15");
            this.Property(t => t.SysDiy16).HasColumnName("SysDiy16");
            this.Property(t => t.efullnamecustom).HasColumnName("efullnamecustom");
            this.Property(t => t.pfullnamecustom).HasColumnName("pfullnamecustom");
            this.Property(t => t.bfullnamecustom).HasColumnName("bfullnamecustom");
            this.Property(t => t.dfullnamecustom).HasColumnName("dfullnamecustom");
            this.Property(t => t.kfullnamecustom).HasColumnName("kfullnamecustom");
            this.Property(t => t.sfullnamecustom).HasColumnName("sfullnamecustom");
            this.Property(t => t.ChangeTotal).HasColumnName("ChangeTotal");
        }
    }
}
