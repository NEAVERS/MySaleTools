using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class HR_PersonMap : EntityTypeConfiguration<HR_Person>
    {
        public HR_PersonMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Name, t.PersonStatus_ID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Name)
                .IsRequired();

            this.Property(t => t.PersonStatus_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Postion_ID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HR_Person");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.parID).HasColumnName("parID");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.delete).HasColumnName("delete");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LoginName).HasColumnName("LoginName");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.IDCard).HasColumnName("IDCard");
            this.Property(t => t.University).HasColumnName("University");
            this.Property(t => t.Speciality).HasColumnName("Speciality");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.BirthDay).HasColumnName("BirthDay");
            this.Property(t => t.Tall).HasColumnName("Tall");
            this.Property(t => t.Intro).HasColumnName("Intro");
            this.Property(t => t.PersonStatus_ID).HasColumnName("PersonStatus_ID");
            this.Property(t => t.Postion_ID).HasColumnName("Postion_ID");
            this.Property(t => t.Hukou).HasColumnName("Hukou");
            this.Property(t => t.Polity).HasColumnName("Polity");
            this.Property(t => t.Marriage).HasColumnName("Marriage");
            this.Property(t => t.Degree).HasColumnName("Degree");
            this.Property(t => t.GraduateDate).HasColumnName("GraduateDate");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.AccessionDate).HasColumnName("AccessionDate");
            this.Property(t => t.OldMonthlyPay).HasColumnName("OldMonthlyPay");
            this.Property(t => t.WantPay).HasColumnName("WantPay");
            this.Property(t => t.LimitID).HasColumnName("LimitID");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
        }
    }
}
