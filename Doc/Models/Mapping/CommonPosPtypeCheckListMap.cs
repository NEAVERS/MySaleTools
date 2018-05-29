using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CommonPosPtypeCheckListMap : EntityTypeConfiguration<CommonPosPtypeCheckList>
    {
        public CommonPosPtypeCheckListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CheckCode, t.CheckList, t.PtypeID, t.Qty, t.IsUpSend, t.UpLoadPosVchCode, t.UniqueID });

            // Properties
            this.Property(t => t.CheckCode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CheckList)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PtypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Qty)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsUpSend)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UpLoadPosVchCode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UniqueID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CommonPosPtypeCheckList");
            this.Property(t => t.CheckCode).HasColumnName("CheckCode");
            this.Property(t => t.CheckList).HasColumnName("CheckList");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.ColorID).HasColumnName("ColorID");
            this.Property(t => t.SizeID).HasColumnName("SizeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.IsUpSend).HasColumnName("IsUpSend");
            this.Property(t => t.UpLoadPosVchCode).HasColumnName("UpLoadPosVchCode");
            this.Property(t => t.UniqueID).HasColumnName("UniqueID");
        }
    }
}
