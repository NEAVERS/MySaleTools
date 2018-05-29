using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_InvoceBillMap : EntityTypeConfiguration<OM_InvoceBill>
    {
        public OM_InvoceBillMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberID);

            // Properties
            // Table & Column Mappings
            this.ToTable("OM_InvoceBill");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillIndex_ID).HasColumnName("BillIndex_ID");
            this.Property(t => t.InvoceQty).HasColumnName("InvoceQty");
            this.Property(t => t.InvocePrice).HasColumnName("InvocePrice");
            this.Property(t => t.InvoceTotalPrice).HasColumnName("InvoceTotalPrice");
            this.Property(t => t.InvocedQty).HasColumnName("InvocedQty");
            this.Property(t => t.InvocedTotalPrice).HasColumnName("InvocedTotalPrice");
            this.Property(t => t.Qty).HasColumnName("Qty");
        }
    }
}
