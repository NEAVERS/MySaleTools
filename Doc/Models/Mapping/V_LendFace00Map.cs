using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class V_LendFace00Map : EntityTypeConfiguration<V_LendFace00>
    {
        public V_LendFace00Map()
        {
            // Primary Key
            this.HasKey(t => new { t.Iscombined, t.ItemID, t.Qty });

            // Properties
            this.Property(t => t.pUserCode)
                .HasMaxLength(200);

            this.Property(t => t.pFullName)
                .HasMaxLength(200);

            this.Property(t => t.pEntryCode)
                .HasMaxLength(200);

            this.Property(t => t.kUserCode)
                .HasMaxLength(26);

            this.Property(t => t.kFullName)
                .HasMaxLength(66);

            this.Property(t => t.STypeID)
                .HasMaxLength(50);

            this.Property(t => t.bUserCode)
                .HasMaxLength(26);

            this.Property(t => t.bFullName)
                .HasMaxLength(66);

            this.Property(t => t.pTypeID)
                .HasMaxLength(50);

            this.Property(t => t.bTypeID)
                .HasMaxLength(50);

            this.Property(t => t.kTypeID)
                .HasMaxLength(50);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.ItemID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.producedate)
                .HasMaxLength(100);

            this.Property(t => t.ValidDate)
                .HasMaxLength(100);

            this.Property(t => t.Qty)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_LendFace00");
            this.Property(t => t.pUserCode).HasColumnName("pUserCode");
            this.Property(t => t.pFullName).HasColumnName("pFullName");
            this.Property(t => t.pEntryCode).HasColumnName("pEntryCode");
            this.Property(t => t.kUserCode).HasColumnName("kUserCode");
            this.Property(t => t.kFullName).HasColumnName("kFullName");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.bUserCode).HasColumnName("bUserCode");
            this.Property(t => t.bFullName).HasColumnName("bFullName");
            this.Property(t => t.pTypeID).HasColumnName("pTypeID");
            this.Property(t => t.bTypeID).HasColumnName("bTypeID");
            this.Property(t => t.kTypeID).HasColumnName("kTypeID");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.Iscombined).HasColumnName("Iscombined");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.producedate).HasColumnName("producedate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Borrow).HasColumnName("Borrow");
            this.Property(t => t.Lend).HasColumnName("Lend");
            this.Property(t => t.NBorrow).HasColumnName("NBorrow");
            this.Property(t => t.NLend).HasColumnName("NLend");
        }
    }
}
