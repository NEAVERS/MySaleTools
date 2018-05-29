using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class IM_MessageMap : EntityTypeConfiguration<IM_Message>
    {
        public IM_MessageMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Content, t.SenderID, t.ReceiverID, t.MessageType, t.CreateDate, t.IsRead });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Title)
                .HasMaxLength(100);

            this.Property(t => t.Content)
                .IsRequired();

            this.Property(t => t.BillNumberID)
                .HasMaxLength(50);

            this.Property(t => t.SenderID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ReceiverID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MessageType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CreateDate)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IsRead)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SenderIP)
                .HasMaxLength(50);

            this.Property(t => t.ReceiverIP)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("IM_Message");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.SenderID).HasColumnName("SenderID");
            this.Property(t => t.ReceiverID).HasColumnName("ReceiverID");
            this.Property(t => t.MessageType).HasColumnName("MessageType");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsRead).HasColumnName("IsRead");
            this.Property(t => t.SenderIP).HasColumnName("SenderIP");
            this.Property(t => t.ReceiverIP).HasColumnName("ReceiverIP");
        }
    }
}
