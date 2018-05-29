using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_ExpensesMap : EntityTypeConfiguration<Ac_Expenses>
    {
        public Ac_ExpensesMap()
        {
            // Primary Key
            this.HasKey(t => t.nid);

            // Properties
            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .HasMaxLength(400);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Ac_Expenses");
            this.Property(t => t.nid).HasColumnName("nid");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
        }
    }
}
