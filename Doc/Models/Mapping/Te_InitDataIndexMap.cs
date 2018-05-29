using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Te_InitDataIndexMap : EntityTypeConfiguration<Te_InitDataIndex>
    {
        public Te_InitDataIndexMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Te_InitDataIndex");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.BUId).HasColumnName("BUId");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Finish).HasColumnName("Finish");
            this.Property(t => t.Rate).HasColumnName("Rate");
        }
    }
}
