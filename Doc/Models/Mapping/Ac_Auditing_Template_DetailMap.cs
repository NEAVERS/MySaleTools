using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Auditing_Template_DetailMap : EntityTypeConfiguration<Ac_Auditing_Template_Detail>
    {
        public Ac_Auditing_Template_DetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AtdId, t.SummaryType });

            // Properties
            this.Property(t => t.AtdId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Summary)
                .HasMaxLength(400);

            this.Property(t => t.AcFrom)
                .HasMaxLength(100);

            this.Property(t => t.ATypeId)
                .HasMaxLength(50);

            this.Property(t => t.BillMoneyId)
                .HasMaxLength(400);

            this.Property(t => t.Express)
                .HasMaxLength(1000);

            this.Property(t => t.AssistCheckItmes)
                .HasMaxLength(200);

            this.Property(t => t.AssistCheckItmesIds)
                .HasMaxLength(200);

            this.Property(t => t.SummaryType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_Auditing_Template_Detail");
            this.Property(t => t.AtdId).HasColumnName("AtdId");
            this.Property(t => t.Atid).HasColumnName("Atid");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.AcFrom).HasColumnName("AcFrom");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.Fdc).HasColumnName("Fdc");
            this.Property(t => t.BillMoneyId).HasColumnName("BillMoneyId");
            this.Property(t => t.Express).HasColumnName("Express");
            this.Property(t => t.AssistCheckItmes).HasColumnName("AssistCheckItmes");
            this.Property(t => t.AssistCheckItmesIds).HasColumnName("AssistCheckItmesIds");
            this.Property(t => t.SummaryType).HasColumnName("SummaryType");
            this.Property(t => t.FromAtdId).HasColumnName("FromAtdId");
        }
    }
}
