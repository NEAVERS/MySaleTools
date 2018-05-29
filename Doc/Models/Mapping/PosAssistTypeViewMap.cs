using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosAssistTypeViewMap : EntityTypeConfiguration<PosAssistTypeView>
    {
        public PosAssistTypeViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.typeid, t.typeorder, t.choose });

            // Properties
            this.Property(t => t.typeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.typename)
                .HasMaxLength(30);

            this.Property(t => t.typeorder)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.choose)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.comment)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("PosAssistTypeView");
            this.Property(t => t.typeid).HasColumnName("typeid");
            this.Property(t => t.typename).HasColumnName("typename");
            this.Property(t => t.typeorder).HasColumnName("typeorder");
            this.Property(t => t.choose).HasColumnName("choose");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
