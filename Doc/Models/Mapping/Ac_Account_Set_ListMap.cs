using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Account_Set_ListMap : EntityTypeConfiguration<Ac_Account_Set_List>
    {
        public Ac_Account_Set_ListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SubId, t.FullName });

            // Properties
            this.Property(t => t.SubId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Cash)
                .HasMaxLength(200);

            this.Property(t => t.Bank)
                .HasMaxLength(200);

            this.Property(t => t.Asset)
                .HasMaxLength(200);

            this.Property(t => t.Depr)
                .HasMaxLength(200);

            this.Property(t => t.Earn)
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("Ac_Account_Set_List");
            this.Property(t => t.SubId).HasColumnName("SubId");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Len1).HasColumnName("Len1");
            this.Property(t => t.Len2).HasColumnName("Len2");
            this.Property(t => t.Len3).HasColumnName("Len3");
            this.Property(t => t.Len4).HasColumnName("Len4");
            this.Property(t => t.Len5).HasColumnName("Len5");
            this.Property(t => t.Len6).HasColumnName("Len6");
            this.Property(t => t.Len7).HasColumnName("Len7");
            this.Property(t => t.Len8).HasColumnName("Len8");
            this.Property(t => t.Len9).HasColumnName("Len9");
            this.Property(t => t.Len10).HasColumnName("Len10");
            this.Property(t => t.Cash).HasColumnName("Cash");
            this.Property(t => t.Bank).HasColumnName("Bank");
            this.Property(t => t.Asset).HasColumnName("Asset");
            this.Property(t => t.Depr).HasColumnName("Depr");
            this.Property(t => t.Earn).HasColumnName("Earn");
            this.Property(t => t.IsVisible).HasColumnName("IsVisible");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.IsUse).HasColumnName("IsUse");
        }
    }
}
