using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_MulColumnAccount_AssistMap : EntityTypeConfiguration<Ac_MulColumnAccount_Assist>
    {
        public Ac_MulColumnAccount_AssistMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.FValue)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_MulColumnAccount_Assist");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AssistID).HasColumnName("AssistID");
            this.Property(t => t.Fdc).HasColumnName("Fdc");
            this.Property(t => t.FValue).HasColumnName("FValue");
        }
    }
}
