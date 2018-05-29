using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosLoginUserViewMap : EntityTypeConfiguration<PosLoginUserView>
    {
        public PosLoginUserViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.etypeid, t.MinDiscount });

            // Properties
            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Password)
                .HasMaxLength(32);

            this.Property(t => t.SysID)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.MinDiscount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KeyNo)
                .HasMaxLength(30);

            this.Property(t => t.SendID)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("PosLoginUserView");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.SysID).HasColumnName("SysID");
            this.Property(t => t.MinDiscount).HasColumnName("MinDiscount");
            this.Property(t => t.KeyNo).HasColumnName("KeyNo");
            this.Property(t => t.SendID).HasColumnName("SendID");
            this.Property(t => t.LockID).HasColumnName("LockID");
            this.Property(t => t.LockLevel).HasColumnName("LockLevel");
        }
    }
}
