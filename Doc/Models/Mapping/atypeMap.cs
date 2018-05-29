using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class atypeMap : EntityTypeConfiguration<atype>
    {
        public atypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.leveal, t.sonnum, t.soncount, t.FullName, t.Name, t.UserCode, t.Comment, t.sysflag, t.sysrow, t.deleted });

            // Properties
            this.Property(t => t.typeId)
                .HasMaxLength(50);

            this.Property(t => t.parid)
                .HasMaxLength(50);

            this.Property(t => t.leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sonnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.soncount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(26);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.sysflag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.PyCode)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("atype");
            this.Property(t => t.typeId).HasColumnName("typeId");
            this.Property(t => t.parid).HasColumnName("parid");
            this.Property(t => t.leveal).HasColumnName("leveal");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Total00).HasColumnName("Total00");
            this.Property(t => t.sysflag).HasColumnName("sysflag");
            this.Property(t => t.sysrow).HasColumnName("sysrow");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.j_d).HasColumnName("j_d");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.ifCanEdit).HasColumnName("ifCanEdit");
            this.Property(t => t.ifCanClass).HasColumnName("ifCanClass");
            this.Property(t => t.ifCanDel).HasColumnName("ifCanDel");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
        }
    }
}
