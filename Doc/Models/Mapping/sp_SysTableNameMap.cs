using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sp_SysTableNameMap : EntityTypeConfiguration<sp_SysTableName>
    {
        public sp_SysTableNameMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sp_TableName)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("sp_SysTableName");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.sp_Id).HasColumnName("sp_Id");
            this.Property(t => t.sp_TableName).HasColumnName("sp_TableName");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
        }
    }
}
