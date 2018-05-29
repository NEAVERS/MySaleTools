using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class FixedAssetsIndexMap : EntityTypeConfiguration<FixedAssetsIndex>
    {
        public FixedAssetsIndexMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberID);

            // Properties
            this.Property(t => t.billcode)
                .HasMaxLength(100);

            this.Property(t => t.stypeid)
                .HasMaxLength(50);

            this.Property(t => t.dtypeId)
                .HasMaxLength(50);

            this.Property(t => t.etypeId)
                .HasMaxLength(50);

            this.Property(t => t.memo)
                .HasMaxLength(200);

            this.Property(t => t.comment)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("FixedAssetsIndex");
            this.Property(t => t.createdate).HasColumnName("createdate");
            this.Property(t => t.billcode).HasColumnName("billcode");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.stypeid).HasColumnName("stypeid");
            this.Property(t => t.dtypeId).HasColumnName("dtypeId");
            this.Property(t => t.etypeId).HasColumnName("etypeId");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.memo).HasColumnName("memo");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
