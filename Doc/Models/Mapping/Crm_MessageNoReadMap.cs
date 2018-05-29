using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Crm_MessageNoReadMap : EntityTypeConfiguration<Crm_MessageNoRead>
    {
        public Crm_MessageNoReadMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Type, t.BeginDate, t.Source, t.SourceTypeID, t.ReadTime, t.SenderName, t.ReceiverName, t.SendMsgID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SenderTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ReceiverTypeID)
                .HasMaxLength(50);

            this.Property(t => t.Content)
                .HasMaxLength(2000);

            this.Property(t => t.CreatorTypeID)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Source)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.SourceTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SenderName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ReceiverName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.SendMsgID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Crm_MessageNoRead");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.SenderTypeID).HasColumnName("SenderTypeID");
            this.Property(t => t.ReceiverTypeID).HasColumnName("ReceiverTypeID");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.IsRead).HasColumnName("IsRead");
            this.Property(t => t.CreatorTypeID).HasColumnName("CreatorTypeID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.BeginDate).HasColumnName("BeginDate");
            this.Property(t => t.Source).HasColumnName("Source");
            this.Property(t => t.SourceTypeID).HasColumnName("SourceTypeID");
            this.Property(t => t.ReadTime).HasColumnName("ReadTime");
            this.Property(t => t.SenderName).HasColumnName("SenderName");
            this.Property(t => t.ReceiverName).HasColumnName("ReceiverName");
            this.Property(t => t.SendMsgID).HasColumnName("SendMsgID");
        }
    }
}
