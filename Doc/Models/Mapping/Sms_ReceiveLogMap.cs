using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Sms_ReceiveLogMap : EntityTypeConfiguration<Sms_ReceiveLog>
    {
        public Sms_ReceiveLogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.QryCode, t.Content, t.RecSTime, t.RecCTime, t.Response, t.SendError, t.State, t.SmsType, t.SendId, t.OperID, t.Deleted });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.QryCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.RecSTime)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RecCTime)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Response)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.SendError)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SmsType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SendId)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.OperID)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.Deleted)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Sms_ReceiveLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PhoneNo).HasColumnName("PhoneNo");
            this.Property(t => t.QryCode).HasColumnName("QryCode");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.RecSTime).HasColumnName("RecSTime");
            this.Property(t => t.RecCTime).HasColumnName("RecCTime");
            this.Property(t => t.Response).HasColumnName("Response");
            this.Property(t => t.SendError).HasColumnName("SendError");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.SmsType).HasColumnName("SmsType");
            this.Property(t => t.SendId).HasColumnName("SendId");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
        }
    }
}
