using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OA_OnlineUserMap : EntityTypeConfiguration<OA_OnlineUser>
    {
        public OA_OnlineUserMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ETypeID_UserTypeID)
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .HasMaxLength(66);

            this.Property(t => t.IP)
                .HasMaxLength(30);

            this.Property(t => t.Status)
                .HasMaxLength(20);

            this.Property(t => t.IPLocal)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OA_OnlineUser");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ETypeID_UserTypeID).HasColumnName("ETypeID_UserTypeID");
            this.Property(t => t.LatestConnectTime).HasColumnName("LatestConnectTime");
            this.Property(t => t.LoginTime).HasColumnName("LoginTime");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.IPLocal).HasColumnName("IPLocal");
        }
    }
}
