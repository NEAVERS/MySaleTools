using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class HotlistMap : EntityTypeConfiguration<Hotlist>
    {
        public HotlistMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Address)
                .HasMaxLength(256);

            this.Property(t => t.Etypeid)
                .HasMaxLength(50);

            this.Property(t => t.Btypeid)
                .HasMaxLength(50);

            this.Property(t => t.Title)
                .HasMaxLength(256);

            this.Property(t => t.Operator)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hotlist");
            this.Property(t => t.HappenDate).HasColumnName("HappenDate");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Etypeid).HasColumnName("Etypeid");
            this.Property(t => t.Btypeid).HasColumnName("Btypeid");
            this.Property(t => t.PloyTypeid).HasColumnName("PloyTypeid");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.New_number).HasColumnName("New_number");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Operator).HasColumnName("Operator");
        }
    }
}
