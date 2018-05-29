using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_ItemsMap : EntityTypeConfiguration<Ac_Items>
    {
        public Ac_ItemsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nId, t.UserCode, t.FullName, t.Deleted });

            // Properties
            this.Property(t => t.nId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.nTypeId)
                .HasMaxLength(50);

            this.Property(t => t.nParId)
                .HasMaxLength(50);

            this.Property(t => t.TypeId)
                .HasMaxLength(50);

            this.Property(t => t.ParId)
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.CreateBank)
                .HasMaxLength(400);

            this.Property(t => t.BankType)
                .HasMaxLength(400);

            this.Property(t => t.Comment)
                .HasMaxLength(400);

            this.Property(t => t.PyCode)
                .HasMaxLength(200);

            this.Property(t => t.Deleted)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TypeName)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("Ac_Items");
            this.Property(t => t.nId).HasColumnName("nId");
            this.Property(t => t.nTypeId).HasColumnName("nTypeId");
            this.Property(t => t.nParId).HasColumnName("nParId");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.ParId).HasColumnName("ParId");
            this.Property(t => t.Leveal).HasColumnName("Leveal");
            this.Property(t => t.SonNum).HasColumnName("SonNum");
            this.Property(t => t.SonCount).HasColumnName("SonCount");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CreateBank).HasColumnName("CreateBank");
            this.Property(t => t.BankType).HasColumnName("BankType");
            this.Property(t => t.IsBank).HasColumnName("IsBank");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.Sysrow).HasColumnName("Sysrow");
            this.Property(t => t.IsModify).HasColumnName("IsModify");
        }
    }
}
