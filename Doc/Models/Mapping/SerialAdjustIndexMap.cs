using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class SerialAdjustIndexMap : EntityTypeConfiguration<SerialAdjustIndex>
    {
        public SerialAdjustIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.BillDate, t.BillCode, t.BillType, t.RedWord, t.draft });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.btypeid)
                .HasMaxLength(50);

            this.Property(t => t.dtypeid)
                .HasMaxLength(50);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.ktypeid)
                .HasMaxLength(50);

            this.Property(t => t.ktypeid2)
                .HasMaxLength(50);

            this.Property(t => t.ifcheck)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.checke)
                .HasMaxLength(50);

            this.Property(t => t.explain)
                .HasMaxLength(500);

            this.Property(t => t.RedWord)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Poster)
                .HasMaxLength(50);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SerialAdjustIndex");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.btypeid).HasColumnName("btypeid");
            this.Property(t => t.dtypeid).HasColumnName("dtypeid");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.ktypeid).HasColumnName("ktypeid");
            this.Property(t => t.ktypeid2).HasColumnName("ktypeid2");
            this.Property(t => t.ifcheck).HasColumnName("ifcheck");
            this.Property(t => t.checke).HasColumnName("checke");
            this.Property(t => t.totalqty).HasColumnName("totalqty");
            this.Property(t => t.period).HasColumnName("period");
            this.Property(t => t.explain).HasColumnName("explain");
            this.Property(t => t.RedWord).HasColumnName("RedWord");
            this.Property(t => t.draft).HasColumnName("draft");
            this.Property(t => t.Poster).HasColumnName("Poster");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.LastUpdateTime).HasColumnName("LastUpdateTime");
        }
    }
}
