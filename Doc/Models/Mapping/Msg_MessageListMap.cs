using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Msg_MessageListMap : EntityTypeConfiguration<Msg_MessageList>
    {
        public Msg_MessageListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.IsRead, t.IsSendDelete, t.IsGetDelete });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Comment)
                .HasMaxLength(1000);

            this.Property(t => t.SendEmployeeID)
                .HasMaxLength(50);

            this.Property(t => t.SendEmployeeName)
                .HasMaxLength(50);

            this.Property(t => t.GetEmployeeID)
                .HasMaxLength(50);

            this.Property(t => t.GetEmployeeName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Msg_MessageList");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MessageDate).HasColumnName("MessageDate");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.SendEmployeeID).HasColumnName("SendEmployeeID");
            this.Property(t => t.SendEmployeeName).HasColumnName("SendEmployeeName");
            this.Property(t => t.GetEmployeeID).HasColumnName("GetEmployeeID");
            this.Property(t => t.GetEmployeeName).HasColumnName("GetEmployeeName");
            this.Property(t => t.IsRead).HasColumnName("IsRead");
            this.Property(t => t.IsSendDelete).HasColumnName("IsSendDelete");
            this.Property(t => t.IsGetDelete).HasColumnName("IsGetDelete");
        }
    }
}
