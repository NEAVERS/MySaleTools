using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class UserGroupManageMap : EntityTypeConfiguration<UserGroupManage>
    {
        public UserGroupManageMap()
        {
            // Primary Key
            this.HasKey(t => t.UserGroupManageId);

            // Properties
            this.Property(t => t.ETypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UserGroupManage");
            this.Property(t => t.UserGroupManageId).HasColumnName("UserGroupManageId");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.UgId).HasColumnName("UgId");
        }
    }
}
