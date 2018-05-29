using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AdvantageMap : EntityTypeConfiguration<Advantage>
    {
        public AdvantageMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.StartDate, t.EndDate, t.Type, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Serial)
                .HasMaxLength(50);

            this.Property(t => t.Ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.StandardCode)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.comment)
                .HasMaxLength(255);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Advantage");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.Ptypeid).HasColumnName("Ptypeid");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.StandardCode).HasColumnName("StandardCode");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.TeamNo1).HasColumnName("TeamNo1");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
        }
    }
}
