using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Old_ListtableMap : EntityTypeConfiguration<Old_Listtable>
    {
        public Old_ListtableMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberId);

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AtypeId)
                .HasMaxLength(50);

            this.Property(t => t.BtypeId)
                .HasMaxLength(50);

            this.Property(t => t.STypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Old_Listtable");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.AtypeId).HasColumnName("AtypeId");
            this.Property(t => t.BtypeId).HasColumnName("BtypeId");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.BillType).HasColumnName("BillType");
        }
    }
}
