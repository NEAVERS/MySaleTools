using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Sms_MessageReviceMap : EntityTypeConfiguration<Sms_MessageRevice>
    {
        public Sms_MessageReviceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PhoneNo)
                .HasMaxLength(50);

            this.Property(t => t.Content)
                .HasMaxLength(1000);

            this.Property(t => t.SendID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Sms_MessageRevice");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PhoneNo).HasColumnName("PhoneNo");
            this.Property(t => t.RecvTime).HasColumnName("RecvTime");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.SendID).HasColumnName("SendID");
            this.Property(t => t.IfRead).HasColumnName("IfRead");
        }
    }
}
