using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_MulColumnAccountMap : EntityTypeConfiguration<Ac_MulColumnAccount>
    {
        public Ac_MulColumnAccountMap()
        {
            // Primary Key
            this.HasKey(t => t.AssistID);

            // Properties
            this.Property(t => t.STypeid)
                .HasMaxLength(50);

            this.Property(t => t.ATypeid)
                .HasMaxLength(50);

            this.Property(t => t.AccountName)
                .HasMaxLength(200);

            this.Property(t => t.Cids)
                .HasMaxLength(100);

            this.Property(t => t.Creator)
                .HasMaxLength(50);

            this.Property(t => t.CreatorStypeId)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Ac_MulColumnAccount");
            this.Property(t => t.STypeid).HasColumnName("STypeid");
            this.Property(t => t.ATypeid).HasColumnName("ATypeid");
            this.Property(t => t.AccountName).HasColumnName("AccountName");
            this.Property(t => t.Ascid).HasColumnName("Ascid");
            this.Property(t => t.flevel).HasColumnName("flevel");
            this.Property(t => t.AssistID).HasColumnName("AssistID");
            this.Property(t => t.Cids).HasColumnName("Cids");
            this.Property(t => t.Flag).HasColumnName("Flag");
            this.Property(t => t.Creator).HasColumnName("Creator");
            this.Property(t => t.CreatorStypeId).HasColumnName("CreatorStypeId");
            this.Property(t => t.IsPublic).HasColumnName("IsPublic");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
