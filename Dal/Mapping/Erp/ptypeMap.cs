using Model.Erp;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping.Erp
{
    class ptypeMap : EntityTypeConfiguration<ptype>
    {
        public ptypeMap()
        {
            this.HasKey(x => x.typeId);
            this.ToTable("ptype");

            this.Property(t => t.typeId).HasColumnName("typeId");
            this.Property(t => t.ParId).HasColumnName("ParId");
            this.Property(t => t.leveal).HasColumnName("leveal");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.CanModify).HasColumnName("CanModify");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Standard");
            this.Property(t => t.Type).HasColumnName("Area");
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

        }
    }
}
