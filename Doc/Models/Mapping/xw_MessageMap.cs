using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class xw_MessageMap : EntityTypeConfiguration<xw_Message>
    {
        public xw_MessageMap()
        {
            // Primary Key
            this.HasKey(t => t.C_Id);

            // Properties
            this.Property(t => t.SenderId)
                .HasMaxLength(100);

            this.Property(t => t.ReceiverId)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Message)
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("xw_Message");
            this.Property(t => t.C_Id).HasColumnName("_Id");
            this.Property(t => t.SenderId).HasColumnName("SenderId");
            this.Property(t => t.ReceiverId).HasColumnName("ReceiverId");
            this.Property(t => t.SendDate).HasColumnName("SendDate");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.IsNew).HasColumnName("IsNew");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
        }
    }
}
