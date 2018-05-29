using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosVipCardBoundViewMap : EntityTypeConfiguration<PosVipCardBoundView>
    {
        public PosVipCardBoundViewMap()
        {
            // Primary Key
            this.HasKey(t => t.CardTypeID);

            // Properties
            this.Property(t => t.CardTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Branchid)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("PosVipCardBoundView");
            this.Property(t => t.CardTypeID).HasColumnName("CardTypeID");
            this.Property(t => t.Branchid).HasColumnName("Branchid");
        }
    }
}
