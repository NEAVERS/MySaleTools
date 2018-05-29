using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class UFO_TempleMap : EntityTypeConfiguration<UFO_Temple>
    {
        public UFO_TempleMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.TempleName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreateEtypeID)
                .HasMaxLength(50);

            this.Property(t => t.UpdateEtypeID)
                .HasMaxLength(50);

            this.Property(t => t.TempleCategoryID)
                .HasMaxLength(50);

            this.Property(t => t.CreateEtypeName)
                .HasMaxLength(50);

            this.Property(t => t.UpdateEtypeName)
                .HasMaxLength(50);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.Fyear)
                .HasMaxLength(20);

            this.Property(t => t.ReMarks)
                .HasMaxLength(100);

            this.Property(t => t.TStypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UFO_Temple");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TempleName).HasColumnName("TempleName");
            this.Property(t => t.ModeID).HasColumnName("ModeID");
            this.Property(t => t.CreateEtypeID).HasColumnName("CreateEtypeID");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.UpdateEtypeID).HasColumnName("UpdateEtypeID");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.TempleContent).HasColumnName("TempleContent");
            this.Property(t => t.IsVisible).HasColumnName("IsVisible");
            this.Property(t => t.TempleCategoryID).HasColumnName("TempleCategoryID");
            this.Property(t => t.CreateEtypeName).HasColumnName("CreateEtypeName");
            this.Property(t => t.UpdateEtypeName).HasColumnName("UpdateEtypeName");
            this.Property(t => t.ClassId).HasColumnName("ClassId");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.Fyear).HasColumnName("Fyear");
            this.Property(t => t.Fperiod).HasColumnName("Fperiod");
            this.Property(t => t.ShownotPost).HasColumnName("ShownotPost");
            this.Property(t => t.IsShare).HasColumnName("IsShare");
            this.Property(t => t.ReMarks).HasColumnName("ReMarks");
            this.Property(t => t.TStypeid).HasColumnName("TStypeid");
            this.Property(t => t.BeginDate).HasColumnName("BeginDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
        }
    }
}
