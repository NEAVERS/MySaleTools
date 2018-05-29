using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OA_SubscibeMap : EntityTypeConfiguration<OA_Subscibe>
    {
        public OA_SubscibeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ETypeID_SubsciberTypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OA_Subscibe");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ArticleID).HasColumnName("ArticleID");
            this.Property(t => t.ETypeID_SubsciberTypeID).HasColumnName("ETypeID_SubsciberTypeID");
        }
    }
}
