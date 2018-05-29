using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class RepairEngageMap : EntityTypeConfiguration<RepairEngage>
    {
        public RepairEngageMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberID, t.BillDate, t.BillCode, t.BillType });

            // Properties
            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PTypeID)
                .HasMaxLength(50);

            this.Property(t => t.Serial)
                .HasMaxLength(100);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.IfCheck)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Checke)
                .HasMaxLength(50);

            this.Property(t => t.ETypeID1)
                .HasMaxLength(50);

            this.Property(t => t.ETypeName1)
                .HasMaxLength(66);

            this.Property(t => t.Tel)
                .HasMaxLength(66);

            this.Property(t => t.SaleBillID)
                .HasMaxLength(66);

            this.Property(t => t.SaleBTypeName)
                .HasMaxLength(66);

            this.Property(t => t.Buyer)
                .HasMaxLength(200);

            this.Property(t => t.Address)
                .HasMaxLength(66);

            this.Property(t => t.Brief)
                .HasMaxLength(200);

            this.Property(t => t.Config)
                .HasMaxLength(8000);

            this.Property(t => t.Attach)
                .HasMaxLength(8000);

            this.Property(t => t.Fault)
                .HasMaxLength(8000);

            this.Property(t => t.Comment)
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("RepairEngage");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.IfCheck).HasColumnName("IfCheck");
            this.Property(t => t.Checke).HasColumnName("Checke");
            this.Property(t => t.RedWord).HasColumnName("RedWord");
            this.Property(t => t.Draft).HasColumnName("Draft");
            this.Property(t => t.Stat).HasColumnName("Stat");
            this.Property(t => t.ETypeID1).HasColumnName("ETypeID1");
            this.Property(t => t.RepairDate).HasColumnName("RepairDate");
            this.Property(t => t.ETypeName1).HasColumnName("ETypeName1");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.BuyDate).HasColumnName("BuyDate");
            this.Property(t => t.SaleBillID).HasColumnName("SaleBillID");
            this.Property(t => t.SaleBTypeName).HasColumnName("SaleBTypeName");
            this.Property(t => t.Buyer).HasColumnName("Buyer");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Brief).HasColumnName("Brief");
            this.Property(t => t.Config).HasColumnName("Config");
            this.Property(t => t.RepairType).HasColumnName("RepairType");
            this.Property(t => t.Attach).HasColumnName("Attach");
            this.Property(t => t.Fault).HasColumnName("Fault");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
