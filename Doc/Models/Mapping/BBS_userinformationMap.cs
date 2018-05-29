using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BBS_userinformationMap : EntityTypeConfiguration<BBS_userinformation>
    {
        public BBS_userinformationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.exp, t.store, t.articlenumber });

            // Properties
            this.Property(t => t.typeID)
                .HasMaxLength(50);

            this.Property(t => t.exp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.store)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.articlenumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BBS_userinformation");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.exp).HasColumnName("exp");
            this.Property(t => t.store).HasColumnName("store");
            this.Property(t => t.articlenumber).HasColumnName("articlenumber");
        }
    }
}
