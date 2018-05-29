using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Te_AccountInTransit_DetailMap : EntityTypeConfiguration<Te_AccountInTransit_Detail>
    {
        public Te_AccountInTransit_DetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Summary });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Summary)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.ETypeId)
                .HasMaxLength(50);

            this.Property(t => t.FSettleNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Te_AccountInTransit_Detail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IndexId).HasColumnName("IndexId");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.FSettleId).HasColumnName("FSettleId");
            this.Property(t => t.FSettleNo).HasColumnName("FSettleNo");
            this.Property(t => t.FDebit).HasColumnName("FDebit");
            this.Property(t => t.FCredit).HasColumnName("FCredit");
            this.Property(t => t.FDebitOri).HasColumnName("FDebitOri");
            this.Property(t => t.FCreditOri).HasColumnName("FCreditOri");
        }
    }
}
