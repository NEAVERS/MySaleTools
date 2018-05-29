using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class tempPtypeMap : EntityTypeConfiguration<tempPtype>
    {
        public tempPtypeMap()
        {
            // Primary Key
            this.HasKey(t => t.typeid);

            // Properties
            this.Property(t => t.typeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OperatorID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tempPtype");
            this.Property(t => t.typeid).HasColumnName("typeid");
            this.Property(t => t.qty).HasColumnName("qty");
            this.Property(t => t.OperatorID).HasColumnName("OperatorID");
        }
    }
}
