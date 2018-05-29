using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class EshopBillRelationMap : EntityTypeConfiguration<EshopBillRelation>
    {
        public EshopBillRelationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.EshopBillID)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("EshopBillRelation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EshopBillID).HasColumnName("EshopBillID");
            this.Property(t => t.Billnumberid).HasColumnName("Billnumberid");
            this.Property(t => t.Flag).HasColumnName("Flag");
        }
    }
}
