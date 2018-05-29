using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_AssetsCardsMap : EntityTypeConfiguration<Ac_AssetsCards>
    {
        public Ac_AssetsCardsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.durmonth });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TypeId)
                .HasMaxLength(50);

            this.Property(t => t.Parid)
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .HasMaxLength(200);

            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            this.Property(t => t.AssertATypeId)
                .HasMaxLength(50);

            this.Property(t => t.DepATypeId)
                .HasMaxLength(50);

            this.Property(t => t.DisATypeId)
                .HasMaxLength(50);

            this.Property(t => t.DevalueATypeId)
                .HasMaxLength(50);

            this.Property(t => t.Size)
                .HasMaxLength(200);

            this.Property(t => t.DTypeid)
                .HasMaxLength(50);

            this.Property(t => t.Units)
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(400);

            this.Property(t => t.ETypeId)
                .HasMaxLength(50);

            this.Property(t => t.BarCode)
                .HasMaxLength(200);

            this.Property(t => t.WorkUnit)
                .HasMaxLength(50);

            this.Property(t => t.durmonth)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Ac_AssetsCards");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.Parid).HasColumnName("Parid");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.AssertATypeId).HasColumnName("AssertATypeId");
            this.Property(t => t.DepATypeId).HasColumnName("DepATypeId");
            this.Property(t => t.DisATypeId).HasColumnName("DisATypeId");
            this.Property(t => t.DevalueATypeId).HasColumnName("DevalueATypeId");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.ConditionId).HasColumnName("ConditionId");
            this.Property(t => t.Size).HasColumnName("Size");
            this.Property(t => t.DTypeid).HasColumnName("DTypeid");
            this.Property(t => t.InAccountDate).HasColumnName("InAccountDate");
            this.Property(t => t.BusinessTypeId).HasColumnName("BusinessTypeId");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.F_Total).HasColumnName("F_Total");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.DepTotal).HasColumnName("DepTotal");
            this.Property(t => t.DevalueReady).HasColumnName("DevalueReady");
            this.Property(t => t.NetValue).HasColumnName("NetValue");
            this.Property(t => t.NetSalvage).HasColumnName("NetSalvage");
            this.Property(t => t.NetSalvageRate).HasColumnName("NetSalvageRate");
            this.Property(t => t.DepreciationMean).HasColumnName("DepreciationMean");
            this.Property(t => t.DurYear).HasColumnName("DurYear");
            this.Property(t => t.DepreciationMonth).HasColumnName("DepreciationMonth");
            this.Property(t => t.Units).HasColumnName("Units");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.AssetsState).HasColumnName("AssetsState");
            this.Property(t => t.OperationDate).HasColumnName("OperationDate");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.BarCode).HasColumnName("BarCode");
            this.Property(t => t.ExpectWork).HasColumnName("ExpectWork");
            this.Property(t => t.FinishWork).HasColumnName("FinishWork");
            this.Property(t => t.WorkUnit).HasColumnName("WorkUnit");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.durmonth).HasColumnName("durmonth");
        }
    }
}
