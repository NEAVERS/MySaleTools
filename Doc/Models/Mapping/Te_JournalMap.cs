using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Te_JournalMap : EntityTypeConfiguration<Te_Journal>
    {
        public Te_JournalMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            this.Property(t => t.ATypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Te_Journal");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Businessdate).HasColumnName("Businessdate");
            this.Property(t => t.YesterdayFBalance).HasColumnName("YesterdayFBalance");
            this.Property(t => t.FDebitTotal).HasColumnName("FDebitTotal");
            this.Property(t => t.FCreditTotal).HasColumnName("FCreditTotal");
            this.Property(t => t.FBalance).HasColumnName("FBalance");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.IsCash).HasColumnName("IsCash");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.FDC).HasColumnName("FDC");
            this.Property(t => t.Cid).HasColumnName("Cid");
        }
    }
}
