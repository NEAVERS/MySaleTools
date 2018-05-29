using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_BillMoney_ListMap : EntityTypeConfiguration<Ac_BillMoney_List>
    {
        public Ac_BillMoney_ListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillMoneyId, t.FullName, t.Express, t.Sysrow });

            // Properties
            this.Property(t => t.BillMoneyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Express)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.Sysrow)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Ac_BillMoney_List");
            this.Property(t => t.BillMoneyId).HasColumnName("BillMoneyId");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Express).HasColumnName("Express");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Sysrow).HasColumnName("Sysrow");
        }
    }
}
