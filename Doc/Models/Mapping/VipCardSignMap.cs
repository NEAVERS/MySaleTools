using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class VipCardSignMap : EntityTypeConfiguration<VipCardSign>
    {
        public VipCardSignMap()
        {
            // Primary Key
            this.HasKey(t => t.VipCardSignId);

            // Properties
            this.Property(t => t.VipCardNo)
                .HasMaxLength(50);

            this.Property(t => t.VipCardOwner)
                .HasMaxLength(100);

            this.Property(t => t.CertificateNo)
                .HasMaxLength(100);

            this.Property(t => t.LinkerPhoneNo)
                .HasMaxLength(50);

            this.Property(t => t.LinkerAddr)
                .HasMaxLength(256);

            this.Property(t => t.BTypeID)
                .HasMaxLength(50);

            this.Property(t => t.Note)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("VipCardSign");
            this.Property(t => t.VipCardSignId).HasColumnName("VipCardSignId");
            this.Property(t => t.VipCardNo).HasColumnName("VipCardNo");
            this.Property(t => t.VipCardId).HasColumnName("VipCardId");
            this.Property(t => t.SignDate).HasColumnName("SignDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.VipCardOwner).HasColumnName("VipCardOwner");
            this.Property(t => t.CertificateNo).HasColumnName("CertificateNo");
            this.Property(t => t.LinkerPhoneNo).HasColumnName("LinkerPhoneNo");
            this.Property(t => t.LinkerAddr).HasColumnName("LinkerAddr");
            this.Property(t => t.BTypeID).HasColumnName("BTypeID");
            this.Property(t => t.VipCardState).HasColumnName("VipCardState");
            this.Property(t => t.VipCardZK).HasColumnName("VipCardZK");
            this.Property(t => t.AutoZk).HasColumnName("AutoZk");
            this.Property(t => t.Note).HasColumnName("Note");
        }
    }
}
