using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_HotListMap : EntityTypeConfiguration<vWeb_HotList>
    {
        public vWeb_HotListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PloyName, t.BFullName, t.EFullName, t.ID });

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(256);

            this.Property(t => t.PloyName)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.BFullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.EFullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.Etypeid)
                .HasMaxLength(50);

            this.Property(t => t.Btypeid)
                .HasMaxLength(50);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Address)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("vWeb_HotList");
            this.Property(t => t.HappenDate).HasColumnName("HappenDate");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.PloyName).HasColumnName("PloyName");
            this.Property(t => t.BFullName).HasColumnName("BFullName");
            this.Property(t => t.EFullName).HasColumnName("EFullName");
            this.Property(t => t.Etypeid).HasColumnName("Etypeid");
            this.Property(t => t.Btypeid).HasColumnName("Btypeid");
            this.Property(t => t.PloyTypeid).HasColumnName("PloyTypeid");
            this.Property(t => t.New_number).HasColumnName("New_number");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
