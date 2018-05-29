using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OA_ASP_DispatchMap : EntityTypeConfiguration<OA_ASP_Dispatch>
    {
        public OA_ASP_DispatchMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.AgentName)
                .HasMaxLength(200);

            this.Property(t => t.AgentBTypeID)
                .HasMaxLength(200);

            this.Property(t => t.AgentVirtualPath)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("OA_ASP_Dispatch");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AgentName).HasColumnName("AgentName");
            this.Property(t => t.AgentBTypeID).HasColumnName("AgentBTypeID");
            this.Property(t => t.AgentVirtualPath).HasColumnName("AgentVirtualPath");
        }
    }
}
