using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceProtectMap : EntityTypeConfiguration<PriceProtect>
    {
        public PriceProtectMap()
        {
            // Primary Key
            this.HasKey(t => t.PriceId);

            // Properties
            this.Property(t => t.Ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.Btypeid)
                .HasMaxLength(50);

            this.Property(t => t.WriteId)
                .HasMaxLength(50);

            this.Property(t => t.State)
                .HasMaxLength(25);

            this.Property(t => t.Billids)
                .HasMaxLength(1500);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PriceProtect");
            this.Property(t => t.PriceId).HasColumnName("PriceId");
            this.Property(t => t.Ptypeid).HasColumnName("Ptypeid");
            this.Property(t => t.Btypeid).HasColumnName("Btypeid");
            this.Property(t => t.OldPrice).HasColumnName("OldPrice");
            this.Property(t => t.NewPrice).HasColumnName("NewPrice");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.WriteDate).HasColumnName("WriteDate");
            this.Property(t => t.WriteId).HasColumnName("WriteId");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.Billids).HasColumnName("Billids");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
        }
    }
}
