using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Msg_OnlineMap : EntityTypeConfiguration<Msg_Online>
    {
        public Msg_OnlineMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ConnectID)
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .HasMaxLength(66);

            this.Property(t => t.Unit)
                .HasMaxLength(100);

            this.Property(t => t.IP)
                .HasMaxLength(15);

            this.Property(t => t.State)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Msg_Online");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ConnectID).HasColumnName("ConnectID");
            this.Property(t => t.LatestConnectTime).HasColumnName("LatestConnectTime");
            this.Property(t => t.LoginTime).HasColumnName("LoginTime");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.State).HasColumnName("State");
        }
    }
}
