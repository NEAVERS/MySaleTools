using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ExpressionMap : EntityTypeConfiguration<Expression>
    {
        public ExpressionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Sub, t.SubName, t.ConstFlag, t.HiddenSub });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.EtypeID)
                .HasMaxLength(50);

            this.Property(t => t.Sub)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.SubName)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Comment)
                .HasMaxLength(1000);

            this.Property(t => t.ConstFlag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HiddenSub)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Expression");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
            this.Property(t => t.Sub).HasColumnName("Sub");
            this.Property(t => t.SubName).HasColumnName("SubName");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.ConstFlag).HasColumnName("ConstFlag");
            this.Property(t => t.HiddenSub).HasColumnName("HiddenSub");
        }
    }
}
