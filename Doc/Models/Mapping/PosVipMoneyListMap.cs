using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosVipMoneyListMap : EntityTypeConfiguration<PosVipMoneyList>
    {
        public PosVipMoneyListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillnumberID, t.PosVchcode, t.VipID, t.SaveAccountSum });

            // Properties
            this.Property(t => t.BillnumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PosVchcode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VipID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SaveAccountSum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosVipMoneyList");
            this.Property(t => t.BillnumberID).HasColumnName("BillnumberID");
            this.Property(t => t.PosVchcode).HasColumnName("PosVchcode");
            this.Property(t => t.VipID).HasColumnName("VipID");
            this.Property(t => t.SaveAccountSum).HasColumnName("SaveAccountSum");
        }
    }
}
