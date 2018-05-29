using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class V_LendFaceMap : EntityTypeConfiguration<V_LendFace>
    {
        public V_LendFaceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.pFullName, t.kFullName, t.bFullName, t.BillNumberID, t.BillDate, t.BillType, t.BillCode, t.CustomdetailID, t.Draft });

            // Properties
            this.Property(t => t.pUserCode)
                .HasMaxLength(200);

            this.Property(t => t.pFullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.pEntryCode)
                .HasMaxLength(200);

            this.Property(t => t.pTypeID)
                .HasMaxLength(50);

            this.Property(t => t.kUserCode)
                .HasMaxLength(26);

            this.Property(t => t.kFullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.kTypeID)
                .HasMaxLength(50);

            this.Property(t => t.bUserCode)
                .HasMaxLength(26);

            this.Property(t => t.bFullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.bTypeID)
                .HasMaxLength(50);

            this.Property(t => t.dealbtypeid)
                .HasMaxLength(50);

            this.Property(t => t.eUserCode)
                .HasMaxLength(26);

            this.Property(t => t.eFullName)
                .HasMaxLength(66);

            this.Property(t => t.eTypeID)
                .HasMaxLength(50);

            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.STypeID)
                .HasMaxLength(50);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.producedate)
                .HasMaxLength(50);

            this.Property(t => t.ValidDate)
                .HasMaxLength(50);

            this.Property(t => t.CustomdetailID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ifcheck)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("V_LendFace");
            this.Property(t => t.pUserCode).HasColumnName("pUserCode");
            this.Property(t => t.pFullName).HasColumnName("pFullName");
            this.Property(t => t.pEntryCode).HasColumnName("pEntryCode");
            this.Property(t => t.pTypeID).HasColumnName("pTypeID");
            this.Property(t => t.kUserCode).HasColumnName("kUserCode");
            this.Property(t => t.kFullName).HasColumnName("kFullName");
            this.Property(t => t.kTypeID).HasColumnName("kTypeID");
            this.Property(t => t.bUserCode).HasColumnName("bUserCode");
            this.Property(t => t.bFullName).HasColumnName("bFullName");
            this.Property(t => t.bTypeID).HasColumnName("bTypeID");
            this.Property(t => t.dealbtypeid).HasColumnName("dealbtypeid");
            this.Property(t => t.eUserCode).HasColumnName("eUserCode");
            this.Property(t => t.eFullName).HasColumnName("eFullName");
            this.Property(t => t.eTypeID).HasColumnName("eTypeID");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.NQty).HasColumnName("NQty");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.producedate).HasColumnName("producedate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.CustomdetailID).HasColumnName("CustomdetailID");
            this.Property(t => t.ifcheck).HasColumnName("ifcheck");
            this.Property(t => t.RedWord).HasColumnName("RedWord");
            this.Property(t => t.Draft).HasColumnName("Draft");
            this.Property(t => t.Borrow).HasColumnName("Borrow");
            this.Property(t => t.BorrowBack).HasColumnName("BorrowBack");
            this.Property(t => t.Lend).HasColumnName("Lend");
            this.Property(t => t.LendBack).HasColumnName("LendBack");
            this.Property(t => t.NBorrow).HasColumnName("NBorrow");
            this.Property(t => t.NBorrowBack).HasColumnName("NBorrowBack");
            this.Property(t => t.NLend).HasColumnName("NLend");
            this.Property(t => t.NLendBack).HasColumnName("NLendBack");
            this.Property(t => t.buyqty).HasColumnName("buyqty");
            this.Property(t => t.saleqty).HasColumnName("saleqty");
        }
    }
}
