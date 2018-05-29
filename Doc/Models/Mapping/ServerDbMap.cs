using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ServerDbMap : EntityTypeConfiguration<ServerDb>
    {
        public ServerDbMap()
        {
            // Primary Key
            this.HasKey(t => t.serverdbId);

            // Properties
            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ip)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.pcName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.dbName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.dbLogin)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.dbPwd)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.connectionString)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ServerDbs");
            this.Property(t => t.serverdbId).HasColumnName("serverdbId");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.ip).HasColumnName("ip");
            this.Property(t => t.pcName).HasColumnName("pcName");
            this.Property(t => t.dbName).HasColumnName("dbName");
            this.Property(t => t.dbLogin).HasColumnName("dbLogin");
            this.Property(t => t.dbPwd).HasColumnName("dbPwd");
            this.Property(t => t.connectionString).HasColumnName("connectionString");
        }
    }
}
