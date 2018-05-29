using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_CartsMap : EntityTypeConfiguration<OM_Carts>
    {
        public OM_CartsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TypeID, t.PtypeID, t.LoginUser_ID, t.Qty, t.Date });

            // Properties
            this.Property(t => t.TypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PtypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LoginUser_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Qty)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OM_Carts");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.LoginUser_ID).HasColumnName("LoginUser_ID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Date).HasColumnName("Date");
        }
    }
}
