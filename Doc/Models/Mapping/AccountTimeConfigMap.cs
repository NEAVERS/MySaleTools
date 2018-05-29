using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AccountTimeConfigMap : EntityTypeConfiguration<AccountTimeConfig>
    {
        public AccountTimeConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ETypeID)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("AccountTimeConfig");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.Col).HasColumnName("Col");
            this.Property(t => t.Col0).HasColumnName("Col0");
            this.Property(t => t.Col1).HasColumnName("Col1");
            this.Property(t => t.Col2).HasColumnName("Col2");
            this.Property(t => t.Col3).HasColumnName("Col3");
            this.Property(t => t.Col4).HasColumnName("Col4");
            this.Property(t => t.Col5).HasColumnName("Col5");
            this.Property(t => t.Col6).HasColumnName("Col6");
            this.Property(t => t.Col7).HasColumnName("Col7");
            this.Property(t => t.Col8).HasColumnName("Col8");
            this.Property(t => t.Col9).HasColumnName("Col9");
        }
    }
}
