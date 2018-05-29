using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CommonPosPtypeCheckNdxMap : EntityTypeConfiguration<CommonPosPtypeCheckNdx>
    {
        public CommonPosPtypeCheckNdxMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CheckCode, t.KtypeID, t.OperatorID, t.PDDate, t.PosID, t.IsUpSend, t.PDNumber, t.PDVchCode, t.UpLoadPosVchCode, t.UniqueID });

            // Properties
            this.Property(t => t.CheckCode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.KtypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OperatorID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PDDate)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.PosID)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.IsUpSend)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PDNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PDVchCode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UpLoadPosVchCode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UniqueID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CommonPosPtypeCheckNdx");
            this.Property(t => t.CheckCode).HasColumnName("CheckCode");
            this.Property(t => t.KtypeID).HasColumnName("KtypeID");
            this.Property(t => t.OperatorID).HasColumnName("OperatorID");
            this.Property(t => t.PDDate).HasColumnName("PDDate");
            this.Property(t => t.PosID).HasColumnName("PosID");
            this.Property(t => t.IsUpSend).HasColumnName("IsUpSend");
            this.Property(t => t.PDNumber).HasColumnName("PDNumber");
            this.Property(t => t.PDVchCode).HasColumnName("PDVchCode");
            this.Property(t => t.UpLoadPosVchCode).HasColumnName("UpLoadPosVchCode");
            this.Property(t => t.UniqueID).HasColumnName("UniqueID");
        }
    }
}
