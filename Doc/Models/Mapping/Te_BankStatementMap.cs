using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Te_BankStatementMap : EntityTypeConfiguration<Te_BankStatement>
    {
        public Te_BankStatementMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Te_BankStatement");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Businessdate).HasColumnName("Businessdate");
            this.Property(t => t.YesterdayFBalance).HasColumnName("YesterdayFBalance");
            this.Property(t => t.FDebitTotal).HasColumnName("FDebitTotal");
            this.Property(t => t.FCreditTotal).HasColumnName("FCreditTotal");
            this.Property(t => t.FBalance).HasColumnName("FBalance");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.FDC).HasColumnName("FDC");
        }
    }
}
