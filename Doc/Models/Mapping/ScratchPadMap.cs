using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ScratchPadMap : EntityTypeConfiguration<ScratchPad>
    {
        public ScratchPadMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.UserID, t.SP_ID, t.SP_X, t.SP_Y, t.Width, t.Hight, t.SP_Text, t.Style, t.Opacity });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserID)
                .IsRequired()
                .HasMaxLength(64);

            this.Property(t => t.SP_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SP_Text)
                .IsRequired();

            this.Property(t => t.Style)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ScratchPad");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.SP_ID).HasColumnName("SP_ID");
            this.Property(t => t.SP_X).HasColumnName("SP_X");
            this.Property(t => t.SP_Y).HasColumnName("SP_Y");
            this.Property(t => t.Width).HasColumnName("Width");
            this.Property(t => t.Hight).HasColumnName("Hight");
            this.Property(t => t.SP_Text).HasColumnName("SP_Text");
            this.Property(t => t.Style).HasColumnName("Style");
            this.Property(t => t.Opacity).HasColumnName("Opacity");
        }
    }
}
