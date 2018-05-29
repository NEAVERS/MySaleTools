using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Yapi_SupplierPtypeRelationMap : EntityTypeConfiguration<Yapi_SupplierPtypeRelation>
    {
        public Yapi_SupplierPtypeRelationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.OnLineFullname)
                .HasMaxLength(200);

            this.Property(t => t.OnLineUserCode)
                .HasMaxLength(200);

            this.Property(t => t.Ptypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Yapi_SupplierPtypeRelation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SupplierID).HasColumnName("SupplierID");
            this.Property(t => t.OnLineID).HasColumnName("OnLineID");
            this.Property(t => t.OnLineFullname).HasColumnName("OnLineFullname");
            this.Property(t => t.OnLineUserCode).HasColumnName("OnLineUserCode");
            this.Property(t => t.Ptypeid).HasColumnName("Ptypeid");
            this.Property(t => t.SkuId).HasColumnName("SkuId");
        }
    }
}
