using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Billindex_CarRepairMap : EntityTypeConfiguration<Billindex_CarRepair>
    {
        public Billindex_CarRepairMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.BillDate, t.BillType, t.RATypeID, t.Status, t.InPriceType, t.InvoiceCode, t.InsuranceStatus });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RATypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OperationSort)
                .HasMaxLength(200);

            this.Property(t => t.RepairMode)
                .HasMaxLength(200);

            this.Property(t => t.Oil)
                .HasMaxLength(200);

            this.Property(t => t.Mileage)
                .HasMaxLength(200);

            this.Property(t => t.EpibolyItem)
                .HasMaxLength(200);

            this.Property(t => t.OtherItem)
                .HasMaxLength(200);

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InPriceType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BTypeID1)
                .HasMaxLength(50);

            this.Property(t => t.InvoiceCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.InsuranceStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReceptionId)
                .HasMaxLength(50);

            this.Property(t => t.UnitSatrap)
                .HasMaxLength(50);

            this.Property(t => t.SendPerson)
                .HasMaxLength(50);

            this.Property(t => t.ErrDescription)
                .HasMaxLength(2000);

            this.Property(t => t.PreferenceReason)
                .HasMaxLength(250);

            this.Property(t => t.ItemPrincipal)
                .HasMaxLength(50);

            this.Property(t => t.MonitorPrincipal)
                .HasMaxLength(50);

            this.Property(t => t.RepairAutoTypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Billindex_CarRepair");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.RATypeID).HasColumnName("RATypeID");
            this.Property(t => t.OperationSort).HasColumnName("OperationSort");
            this.Property(t => t.RepairMode).HasColumnName("RepairMode");
            this.Property(t => t.Oil).HasColumnName("Oil");
            this.Property(t => t.Mileage).HasColumnName("Mileage");
            this.Property(t => t.EpibolyItem).HasColumnName("EpibolyItem");
            this.Property(t => t.OtherItem).HasColumnName("OtherItem");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ManHourTotal).HasColumnName("ManHourTotal");
            this.Property(t => t.ManHourTax).HasColumnName("ManHourTax");
            this.Property(t => t.ManHourTaxTotal).HasColumnName("ManHourTaxTotal");
            this.Property(t => t.PTypeTotal).HasColumnName("PTypeTotal");
            this.Property(t => t.PTypeTax).HasColumnName("PTypeTax");
            this.Property(t => t.PTypeTaxTotal).HasColumnName("PTypeTaxTotal");
            this.Property(t => t.EpibolyTotal).HasColumnName("EpibolyTotal");
            this.Property(t => t.OtherTotal).HasColumnName("OtherTotal");
            this.Property(t => t.InPriceType).HasColumnName("InPriceType");
            this.Property(t => t.BTypeID1).HasColumnName("BTypeID1");
            this.Property(t => t.QuickRepairBillID).HasColumnName("QuickRepairBillID");
            this.Property(t => t.ManHourInsuranceTotal).HasColumnName("ManHourInsuranceTotal");
            this.Property(t => t.PTypeInsuranceTotal).HasColumnName("PTypeInsuranceTotal");
            this.Property(t => t.InvoiceMode).HasColumnName("InvoiceMode");
            this.Property(t => t.InvoiceCode).HasColumnName("InvoiceCode");
            this.Property(t => t.InsuranceStatus).HasColumnName("InsuranceStatus");
            this.Property(t => t.RepairType).HasColumnName("RepairType");
            this.Property(t => t.BespokeDate).HasColumnName("BespokeDate");
            this.Property(t => t.ReceptionDate).HasColumnName("ReceptionDate");
            this.Property(t => t.CompleteDate).HasColumnName("CompleteDate");
            this.Property(t => t.InFactoryDate).HasColumnName("InFactoryDate");
            this.Property(t => t.FactCompleteDate).HasColumnName("FactCompleteDate");
            this.Property(t => t.ReceptionId).HasColumnName("ReceptionId");
            this.Property(t => t.UnitSatrap).HasColumnName("UnitSatrap");
            this.Property(t => t.SendPerson).HasColumnName("SendPerson");
            this.Property(t => t.ErrDescription).HasColumnName("ErrDescription");
            this.Property(t => t.EpibolyCostTotal).HasColumnName("EpibolyCostTotal");
            this.Property(t => t.PreferenceReason).HasColumnName("PreferenceReason");
            this.Property(t => t.BalanceDate).HasColumnName("BalanceDate");
            this.Property(t => t.ItemPrincipal).HasColumnName("ItemPrincipal");
            this.Property(t => t.MonitorPrincipal).HasColumnName("MonitorPrincipal");
            this.Property(t => t.BillState).HasColumnName("BillState");
            this.Property(t => t.IntendingKickback).HasColumnName("IntendingKickback");
            this.Property(t => t.SettlementKickback).HasColumnName("SettlementKickback");
            this.Property(t => t.BackTypeId).HasColumnName("BackTypeId");
            this.Property(t => t.IntendingTalkBackDate).HasColumnName("IntendingTalkBackDate");
            this.Property(t => t.IsTalkBackOver).HasColumnName("IsTalkBackOver");
            this.Property(t => t.CounterClaimStatus).HasColumnName("CounterClaimStatus");
            this.Property(t => t.CzBeforeTimes).HasColumnName("CzBeforeTimes");
            this.Property(t => t.RepairAutoTypeId).HasColumnName("RepairAutoTypeId");
        }
    }
}
