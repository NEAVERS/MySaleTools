using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class V_LendStatusMap : EntityTypeConfiguration<V_LendStatus>
    {
        public V_LendStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.BillDate);

            // Properties
            this.Property(t => t.pUserCode)
                .HasMaxLength(200);

            this.Property(t => t.pFullName)
                .HasMaxLength(200);

            this.Property(t => t.pTypeID)
                .HasMaxLength(50);

            this.Property(t => t.kUserCode)
                .HasMaxLength(26);

            this.Property(t => t.kFullName)
                .HasMaxLength(66);

            this.Property(t => t.kTypeID)
                .HasMaxLength(50);

            this.Property(t => t.bUserCode)
                .HasMaxLength(26);

            this.Property(t => t.bFullName)
                .HasMaxLength(66);

            this.Property(t => t.bTypeID)
                .HasMaxLength(50);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.producedate)
                .HasMaxLength(100);

            this.Property(t => t.ValidDate)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("V_LendStatus");
            this.Property(t => t.pUserCode).HasColumnName("pUserCode");
            this.Property(t => t.pFullName).HasColumnName("pFullName");
            this.Property(t => t.pTypeID).HasColumnName("pTypeID");
            this.Property(t => t.kUserCode).HasColumnName("kUserCode");
            this.Property(t => t.kFullName).HasColumnName("kFullName");
            this.Property(t => t.kTypeID).HasColumnName("kTypeID");
            this.Property(t => t.bUserCode).HasColumnName("bUserCode");
            this.Property(t => t.bFullName).HasColumnName("bFullName");
            this.Property(t => t.bTypeID).HasColumnName("bTypeID");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.producedate).HasColumnName("producedate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Borrow).HasColumnName("Borrow");
            this.Property(t => t.BorrowBack).HasColumnName("BorrowBack");
            this.Property(t => t.Lend).HasColumnName("Lend");
            this.Property(t => t.LendBack).HasColumnName("LendBack");
            this.Property(t => t.NBorrow).HasColumnName("NBorrow");
            this.Property(t => t.NBorrowBack).HasColumnName("NBorrowBack");
            this.Property(t => t.NLend).HasColumnName("NLend");
            this.Property(t => t.NLendBack).HasColumnName("NLendBack");
            this.Property(t => t.saleqty).HasColumnName("saleqty");
            this.Property(t => t.buyqty).HasColumnName("buyqty");
        }
    }
}
