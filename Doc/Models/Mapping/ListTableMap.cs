using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ListTableMap : EntityTypeConfiguration<ListTable>
    {
        public ListTableMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.BillType, t.Audited, t.Id });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AtypeId)
                .HasMaxLength(50);

            this.Property(t => t.PtypeId)
                .HasMaxLength(50);

            this.Property(t => t.BtypeId)
                .HasMaxLength(50);

            this.Property(t => t.EtypeId)
                .HasMaxLength(50);

            this.Property(t => t.KtypeId)
                .HasMaxLength(50);

            this.Property(t => t.JobNumber)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.Ifout)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.DTypeID)
                .HasMaxLength(50);

            this.Property(t => t.STypeID)
                .HasMaxLength(50);

            this.Property(t => t.STypeID2)
                .HasMaxLength(50);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("ListTable");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.AtypeId).HasColumnName("AtypeId");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.BtypeId).HasColumnName("BtypeId");
            this.Property(t => t.EtypeId).HasColumnName("EtypeId");
            this.Property(t => t.KtypeId).HasColumnName("KtypeId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.CostPrice).HasColumnName("CostPrice");
            this.Property(t => t.CostTotal).HasColumnName("CostTotal");
            this.Property(t => t.JobNumber).HasColumnName("JobNumber");
            this.Property(t => t.GoodsNo).HasColumnName("GoodsNo");
            this.Property(t => t.OutFactoryDate).HasColumnName("OutFactoryDate");
            this.Property(t => t.Audited).HasColumnName("Audited");
            this.Property(t => t.Ifout).HasColumnName("Ifout");
            this.Property(t => t.DTypeID).HasColumnName("DTypeID");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.STypeID2).HasColumnName("STypeID2");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.Ntotal).HasColumnName("Ntotal");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Rate).HasColumnName("Rate");
        }
    }
}
