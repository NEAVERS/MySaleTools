using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class UFO_DefineFunctionsMap : EntityTypeConfiguration<UFO_DefineFunctions>
    {
        public UFO_DefineFunctionsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Fuction)
                .HasMaxLength(300);

            this.Property(t => t.Format)
                .HasMaxLength(400);

            this.Property(t => t.Description)
                .HasMaxLength(300);

            this.Property(t => t.Demo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ExampleRemark)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("UFO_DefineFunctions");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Fuction).HasColumnName("Fuction");
            this.Property(t => t.Format).HasColumnName("Format");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Demo).HasColumnName("Demo");
            this.Property(t => t.ExampleRemark).HasColumnName("ExampleRemark");
            this.Property(t => t.Typeid).HasColumnName("Typeid");
        }
    }
}
