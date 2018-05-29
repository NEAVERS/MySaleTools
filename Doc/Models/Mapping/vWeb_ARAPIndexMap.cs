using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_ARAPIndexMap : EntityTypeConfiguration<vWeb_ARAPIndex>
    {
        public vWeb_ARAPIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillCode, t.BillNumberId, t.BillDate, t.BillType, t.RedWord });

            // Properties
            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.btypeid)
                .HasMaxLength(50);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.atypeid)
                .HasMaxLength(50);

            this.Property(t => t.RedWord)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vWeb_ARAPIndex");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.btypeid).HasColumnName("btypeid");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.totalinmoney).HasColumnName("totalinmoney");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.atypeid).HasColumnName("atypeid");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.RedWord).HasColumnName("RedWord");
        }
    }
}
