using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vPtypeUnitALLMap : EntityTypeConfiguration<vPtypeUnitALL>
    {
        public vPtypeUnitALLMap()
        {
            // Primary Key
            this.HasKey(t => new { t.leveal, t.sonnum, t.FullName, t.deleted, t.baseUnitRate, t.buyUnitRate, t.saleUnitRate, t.stockUnitRate });

            // Properties
            this.Property(t => t.typeId)
                .HasMaxLength(50);

            this.Property(t => t.ParId)
                .HasMaxLength(50);

            this.Property(t => t.leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sonnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.EntryCode)
                .HasMaxLength(200);

            this.Property(t => t.Area)
                .HasMaxLength(200);

            this.Property(t => t.baseUnitRate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.buyUnitRate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.saleUnitRate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.stockUnitRate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.buyunitfullname)
                .HasMaxLength(200);

            this.Property(t => t.saleunitfullname)
                .HasMaxLength(200);

            this.Property(t => t.stockunitfullname)
                .HasMaxLength(200);

            this.Property(t => t.baseunitfullname)
                .HasMaxLength(200);

            this.Property(t => t.assistantfullname)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("vPtypeUnitALL");
            this.Property(t => t.typeId).HasColumnName("typeId");
            this.Property(t => t.ParId).HasColumnName("ParId");
            this.Property(t => t.leveal).HasColumnName("leveal");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.EntryCode).HasColumnName("EntryCode");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.baseUnitRate).HasColumnName("baseUnitRate");
            this.Property(t => t.buyUnitRate).HasColumnName("buyUnitRate");
            this.Property(t => t.saleUnitRate).HasColumnName("saleUnitRate");
            this.Property(t => t.stockUnitRate).HasColumnName("stockUnitRate");
            this.Property(t => t.buyunitfullname).HasColumnName("buyunitfullname");
            this.Property(t => t.saleunitfullname).HasColumnName("saleunitfullname");
            this.Property(t => t.stockunitfullname).HasColumnName("stockunitfullname");
            this.Property(t => t.baseunitfullname).HasColumnName("baseunitfullname");
            this.Property(t => t.assistantfullname).HasColumnName("assistantfullname");
        }
    }
}
