using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_BillIndexMap : EntityTypeConfiguration<OM_BillIndex>
    {
        public OM_BillIndexMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberID);

            // Properties
            this.Property(t => t.CancelReason)
                .HasMaxLength(500);

            this.Property(t => t.BillCode)
                .HasMaxLength(200);

            this.Property(t => t.BtypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OM_BillIndex");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.CancelReason).HasColumnName("CancelReason");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.BtypeID).HasColumnName("BtypeID");
            this.Property(t => t.LoginUser_ID).HasColumnName("LoginUser_ID");
            this.Property(t => t.TotalReturnQty).HasColumnName("TotalReturnQty");
            this.Property(t => t.CompeledDate).HasColumnName("CompeledDate");
        }
    }
}
