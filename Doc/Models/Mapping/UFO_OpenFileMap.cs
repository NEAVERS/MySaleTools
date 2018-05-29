using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class UFO_OpenFileMap : EntityTypeConfiguration<UFO_OpenFile>
    {
        public UFO_OpenFileMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nId, t.STypeID, t.AtypeID, t.Cid, t.CreatedBy });

            // Properties
            this.Property(t => t.nId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.STypeID)
                .IsRequired();

            this.Property(t => t.AtypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FunctionName)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("UFO_OpenFile");
            this.Property(t => t.nId).HasColumnName("nId");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.AtypeID).HasColumnName("AtypeID");
            this.Property(t => t.BeginDate).HasColumnName("BeginDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Fyear).HasColumnName("Fyear");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
            this.Property(t => t.ShowNotPost).HasColumnName("ShowNotPost");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Assets).HasColumnName("Assets");
            this.Property(t => t.FunctionName).HasColumnName("FunctionName");
        }
    }
}
