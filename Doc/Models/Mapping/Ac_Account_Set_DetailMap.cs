using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Account_Set_DetailMap : EntityTypeConfiguration<Ac_Account_Set_Detail>
    {
        public Ac_Account_Set_DetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DtId, t.SubId });

            // Properties
            this.Property(t => t.DtId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.SubId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Group)
                .HasMaxLength(200);

            this.Property(t => t.TypeId)
                .HasMaxLength(50);

            this.Property(t => t.ParId)
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .HasMaxLength(200);

            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(400);

            this.Property(t => t.PyCode)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Ac_Account_Set_Detail");
            this.Property(t => t.DtId).HasColumnName("DtId");
            this.Property(t => t.SubId).HasColumnName("SubId");
            this.Property(t => t.Group).HasColumnName("Group");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.ParId).HasColumnName("ParId");
            this.Property(t => t.FLeveal).HasColumnName("FLeveal");
            this.Property(t => t.Leveal).HasColumnName("Leveal");
            this.Property(t => t.SonNum).HasColumnName("SonNum");
            this.Property(t => t.SonCount).HasColumnName("SonCount");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Fdc).HasColumnName("Fdc");
            this.Property(t => t.IsCash).HasColumnName("IsCash");
            this.Property(t => t.IsBank).HasColumnName("IsBank");
            this.Property(t => t.IsOther).HasColumnName("IsOther");
            this.Property(t => t.fcontact).HasColumnName("fcontact");
            this.Property(t => t.checktype).HasColumnName("checktype");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
        }
    }
}
