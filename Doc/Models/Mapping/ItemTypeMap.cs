using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ItemTypeMap : EntityTypeConfiguration<ItemType>
    {
        public ItemTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nId, t.leveal, t.sonnum, t.soncount, t.UserCode, t.FullName, t.Attribute, t.STypeid, t.deleted });

            // Properties
            this.Property(t => t.nId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.typeId)
                .HasMaxLength(50);

            this.Property(t => t.ParId)
                .HasMaxLength(50);

            this.Property(t => t.leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sonnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.soncount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CanModify)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Attribute)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(250);

            this.Property(t => t.STypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PyCode)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("ItemType");
            this.Property(t => t.nId).HasColumnName("nId");
            this.Property(t => t.typeId).HasColumnName("typeId");
            this.Property(t => t.ParId).HasColumnName("ParId");
            this.Property(t => t.leveal).HasColumnName("leveal");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.CanModify).HasColumnName("CanModify");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Attribute).HasColumnName("Attribute");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.STypeid).HasColumnName("STypeid");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
        }
    }
}
