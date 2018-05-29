using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Te_InitDataDetailMap : EntityTypeConfiguration<Te_InitDataDetail>
    {
        public Te_InitDataDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AtypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Te_InitDataDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IndexId).HasColumnName("IndexId");
            this.Property(t => t.AtypeId).HasColumnName("AtypeId");
            this.Property(t => t.FDebit).HasColumnName("FDebit");
            this.Property(t => t.FCredit).HasColumnName("FCredit");
            this.Property(t => t.InitBalance).HasColumnName("InitBalance");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.FDebitOri).HasColumnName("FDebitOri");
            this.Property(t => t.FCreditOri).HasColumnName("FCreditOri");
            this.Property(t => t.InitBalanceOri).HasColumnName("InitBalanceOri");
        }
    }
}
