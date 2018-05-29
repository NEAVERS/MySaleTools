using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class IsStartOkMap : EntityTypeConfiguration<IsStartOk>
    {
        public IsStartOkMap()
        {
            // Primary Key
            this.HasKey(t => new { t.userID, t.stypeID, t.isOpen });

            // Properties
            this.Property(t => t.userID)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.stypeID)
                .IsRequired();

            this.Property(t => t.isOpen)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("IsStartOk");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.parID).HasColumnName("parID");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.delete).HasColumnName("delete");
            this.Property(t => t.userID).HasColumnName("userID");
            this.Property(t => t.stypeID).HasColumnName("stypeID");
            this.Property(t => t.isOpen).HasColumnName("isOpen");
        }
    }
}
