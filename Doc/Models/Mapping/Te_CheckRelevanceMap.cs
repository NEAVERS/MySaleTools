using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Te_CheckRelevanceMap : EntityTypeConfiguration<Te_CheckRelevance>
    {
        public Te_CheckRelevanceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Te_CheckRelevance");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.JournalId).HasColumnName("JournalId");
            this.Property(t => t.StatementId).HasColumnName("StatementId");
            this.Property(t => t.RelevanceDate).HasColumnName("RelevanceDate");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.StatementAccountInTransitId).HasColumnName("StatementAccountInTransitId");
            this.Property(t => t.JournalAccountInTransitId).HasColumnName("JournalAccountInTransitId");
        }
    }
}
