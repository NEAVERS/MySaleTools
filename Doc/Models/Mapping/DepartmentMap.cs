using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.leveal, t.sonnum, t.soncount, t.usercode, t.FullName, t.Comment, t.deleted, t.rec, t.namepy, t.parrec, t.OrderNo });

            // Properties
            this.Property(t => t.typeid)
                .HasMaxLength(50);

            this.Property(t => t.parid)
                .HasMaxLength(50);

            this.Property(t => t.leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sonnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.soncount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.usercode)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Name)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Tel)
                .HasMaxLength(50);

            this.Property(t => t.LinkMan)
                .HasMaxLength(50);

            this.Property(t => t.Fax)
                .HasMaxLength(50);

            this.Property(t => t.rec)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.namepy)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.parrec)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PyCode)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Department");
            this.Property(t => t.typeid).HasColumnName("typeid");
            this.Property(t => t.parid).HasColumnName("parid");
            this.Property(t => t.leveal).HasColumnName("leveal");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.usercode).HasColumnName("usercode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.LinkMan).HasColumnName("LinkMan");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.rec).HasColumnName("rec");
            this.Property(t => t.namepy).HasColumnName("namepy");
            this.Property(t => t.parrec).HasColumnName("parrec");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
        }
    }
}
