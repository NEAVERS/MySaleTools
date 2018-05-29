using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Te_AccountInTransit_IndexMap : EntityTypeConfiguration<Te_AccountInTransit_Index>
    {
        public Te_AccountInTransit_IndexMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ATypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Te_AccountInTransit_Index");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.FDebitTotal).HasColumnName("FDebitTotal");
            this.Property(t => t.FCreditTotal).HasColumnName("FCreditTotal");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.IsInit).HasColumnName("IsInit");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.FDebitTotalOri).HasColumnName("FDebitTotalOri");
            this.Property(t => t.FCreditTotalOri).HasColumnName("FCreditTotalOri");
        }
    }
}
