using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosVipCardExpandViewMap : EntityTypeConfiguration<PosVipCardExpandView>
    {
        public PosVipCardExpandViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CardTypeid, t.oneconsume, t.allconsume, t.Integral1, t.Integral2, t.ExpandType, t.Base, t.Percent, t.isshop, t.batchno });

            // Properties
            this.Property(t => t.CardTypeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.oneconsume)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.allconsume)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Integral1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Integral2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExpandType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Base)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Percent)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.isshop)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.atypeid)
                .HasMaxLength(30);

            this.Property(t => t.batchno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosVipCardExpandView");
            this.Property(t => t.CardTypeid).HasColumnName("CardTypeid");
            this.Property(t => t.oneconsume).HasColumnName("oneconsume");
            this.Property(t => t.allconsume).HasColumnName("allconsume");
            this.Property(t => t.Integral1).HasColumnName("Integral1");
            this.Property(t => t.Integral2).HasColumnName("Integral2");
            this.Property(t => t.ExpandType).HasColumnName("ExpandType");
            this.Property(t => t.Base).HasColumnName("Base");
            this.Property(t => t.Percent).HasColumnName("Percent");
            this.Property(t => t.isshop).HasColumnName("isshop");
            this.Property(t => t.atypeid).HasColumnName("atypeid");
            this.Property(t => t.batchno).HasColumnName("batchno");
        }
    }
}
