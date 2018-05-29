using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_IntendingTalkBack_BillMap : EntityTypeConfiguration<Qp_IntendingTalkBack_Bill>
    {
        public Qp_IntendingTalkBack_BillMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberId);

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.RepairContentmentDegree)
                .HasMaxLength(200);

            this.Property(t => t.CompContentmentDegree)
                .HasMaxLength(200);

            this.Property(t => t.CustomerQuestion)
                .HasMaxLength(2000);

            this.Property(t => t.DealResult)
                .HasMaxLength(2000);

            this.Property(t => t.Comment)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Qp_IntendingTalkBack_Bill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.RepairContentmentDegree).HasColumnName("RepairContentmentDegree");
            this.Property(t => t.CompContentmentDegree).HasColumnName("CompContentmentDegree");
            this.Property(t => t.CustomerQuestion).HasColumnName("CustomerQuestion");
            this.Property(t => t.DealResult).HasColumnName("DealResult");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
