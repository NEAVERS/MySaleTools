using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OA_Vote_EmployeeVoteInfoMap : EntityTypeConfiguration<OA_Vote_EmployeeVoteInfo>
    {
        public OA_Vote_EmployeeVoteInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.VoteID, t.ETypeID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.VoteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ETypeID)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OA_Vote_EmployeeVoteInfo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.VoteID).HasColumnName("VoteID");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
        }
    }
}
