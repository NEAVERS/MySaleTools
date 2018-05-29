using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class IM_Message_NoSocketMap : EntityTypeConfiguration<IM_Message_NoSocket>
    {
        public IM_Message_NoSocketMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Content, t.SenderID, t.SenderName, t.ReceiverID, t.ReceiverName, t.MessageType, t.CreateDate, t.IsRead, t.BillNumberId });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Title)
                .HasMaxLength(100);

            this.Property(t => t.Content)
                .IsRequired();

            this.Property(t => t.TypeID)
                .HasMaxLength(50);

            this.Property(t => t.SenderID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SenderName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.ReceiverID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ReceiverName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.MessageType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IsRead)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SenderIP)
                .HasMaxLength(50);

            this.Property(t => t.ReceiverIP)
                .HasMaxLength(50);

            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("IM_Message_NoSocket");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.SenderID).HasColumnName("SenderID");
            this.Property(t => t.SenderName).HasColumnName("SenderName");
            this.Property(t => t.ReceiverID).HasColumnName("ReceiverID");
            this.Property(t => t.ReceiverName).HasColumnName("ReceiverName");
            this.Property(t => t.MessageType).HasColumnName("MessageType");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsRead).HasColumnName("IsRead");
            this.Property(t => t.SenderIP).HasColumnName("SenderIP");
            this.Property(t => t.ReceiverIP).HasColumnName("ReceiverIP");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
        }
    }
}
