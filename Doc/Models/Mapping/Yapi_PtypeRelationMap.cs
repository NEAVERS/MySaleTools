using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Yapi_PtypeRelationMap : EntityTypeConfiguration<Yapi_PtypeRelation>
    {
        public Yapi_PtypeRelationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Ptypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Yapi_PtypeRelation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Ptypeid).HasColumnName("Ptypeid");
            this.Property(t => t.OnLineID).HasColumnName("OnLineID");
            this.Property(t => t.SkuId).HasColumnName("SkuId");
        }
    }
}
