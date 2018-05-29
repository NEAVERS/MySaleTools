using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class crm_linkmanMap : EntityTypeConfiguration<crm_linkman>
    {
        public crm_linkmanMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.createorName, t.LinkMan, t.LinkSex, t.Deleted, t.CreateDate });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.createor)
                .HasMaxLength(50);

            this.Property(t => t.createorName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LinkMan)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LinkJob)
                .HasMaxLength(50);

            this.Property(t => t.LinkCall)
                .HasMaxLength(50);

            this.Property(t => t.LinkTel)
                .HasMaxLength(50);

            this.Property(t => t.LinkMobile)
                .HasMaxLength(50);

            this.Property(t => t.LinkPost)
                .HasMaxLength(10);

            this.Property(t => t.LinkAddress)
                .HasMaxLength(50);

            this.Property(t => t.LinkEmail)
                .HasMaxLength(50);

            this.Property(t => t.LinkComment)
                .HasMaxLength(256);

            this.Property(t => t.Deleted)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("crm_linkman");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.createor).HasColumnName("createor");
            this.Property(t => t.createorName).HasColumnName("createorName");
            this.Property(t => t.Crm_BtypeId).HasColumnName("Crm_BtypeId");
            this.Property(t => t.LinkMan).HasColumnName("LinkMan");
            this.Property(t => t.LinkSex).HasColumnName("LinkSex");
            this.Property(t => t.LinkBirthDay).HasColumnName("LinkBirthDay");
            this.Property(t => t.LinkJob).HasColumnName("LinkJob");
            this.Property(t => t.LinkCall).HasColumnName("LinkCall");
            this.Property(t => t.LinkTel).HasColumnName("LinkTel");
            this.Property(t => t.LinkMobile).HasColumnName("LinkMobile");
            this.Property(t => t.LinkPost).HasColumnName("LinkPost");
            this.Property(t => t.LinkAddress).HasColumnName("LinkAddress");
            this.Property(t => t.LinkEmail).HasColumnName("LinkEmail");
            this.Property(t => t.LinkComment).HasColumnName("LinkComment");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
        }
    }
}
