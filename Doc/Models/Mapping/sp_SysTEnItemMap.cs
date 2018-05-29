using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sp_SysTEnItemMap : EntityTypeConfiguration<sp_SysTEnItem>
    {
        public sp_SysTEnItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.En_Item)
                .HasMaxLength(200);

            this.Property(t => t.Align)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("sp_SysTEnItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.sp_Id).HasColumnName("sp_Id");
            this.Property(t => t.sp_SysTableName_Id).HasColumnName("sp_SysTableName_Id");
            this.Property(t => t.En_Item).HasColumnName("En_Item");
            this.Property(t => t.Align).HasColumnName("Align");
            this.Property(t => t.Format).HasColumnName("Format");
            this.Property(t => t.Format_Num).HasColumnName("Format_Num");
            this.Property(t => t.is_Sum).HasColumnName("is_Sum");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.is_Hidden).HasColumnName("is_Hidden");
        }
    }
}
