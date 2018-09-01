using Model.Erp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping.Erp
{
    public class employeeMap : EntityTypeConfiguration<employee>
    {
        public employeeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.leveal, t.soncount, t.sonnum, t.FullName, t.deleted, t.Eid });

            // Properties
            this.Property(t => t.BtypeID)
                .HasMaxLength(50);

            this.Property(t => t.typeId)
                .HasMaxLength(50);

            this.Property(t => t.Parid)
                .HasMaxLength(50);

            this.Property(t => t.leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.soncount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sonnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.Name)
                .HasMaxLength(30);

            this.Property(t => t.UserCode)
                .HasMaxLength(26);

            this.Property(t => t.Department)
                .HasMaxLength(100);

            this.Property(t => t.Tel)
                .HasMaxLength(20);

            this.Property(t => t.Address)
                .HasMaxLength(66);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.Nation)
                .HasMaxLength(20);

            this.Property(t => t.Knowledge)
                .HasMaxLength(20);

            this.Property(t => t.Blood)
                .HasMaxLength(20);

            this.Property(t => t.Health)
                .HasMaxLength(256);

            this.Property(t => t.IDcard)
                .HasMaxLength(50);

            this.Property(t => t.Job)
                .HasMaxLength(50);

            this.Property(t => t.Job2)
                .HasMaxLength(50);

            this.Property(t => t.Tel2)
                .HasMaxLength(50);

            this.Property(t => t.Mob)
                .HasMaxLength(50);

            this.Property(t => t.Mail)
                .HasMaxLength(50);

            this.Property(t => t.political)
                .HasMaxLength(20);

            this.Property(t => t.nat_place)
                .HasMaxLength(20);

            this.Property(t => t.college)
                .HasMaxLength(50);

            this.Property(t => t.for_language)
                .HasMaxLength(20);

            this.Property(t => t.reg_place)
                .HasMaxLength(50);

            this.Property(t => t.com_level)
                .HasMaxLength(20);

            this.Property(t => t.fam_status)
                .HasMaxLength(50);

            this.Property(t => t.informer)
                .HasMaxLength(20);

            this.Property(t => t.speciality)
                .HasMaxLength(50);

            this.Property(t => t.for_lan_level)
                .HasMaxLength(20);

            this.Property(t => t.PostCode)
                .HasMaxLength(10);

            this.Property(t => t.Email)
                .HasMaxLength(100);

            this.Property(t => t.DtypeID)
                .HasMaxLength(50);

            this.Property(t => t.PyCode)
                .HasMaxLength(500);

            this.Property(t => t.smsMobile)
                .HasMaxLength(50);

            this.Property(t => t.smsComment)
                .HasMaxLength(256);

            this.Property(t => t.STypeID)
                .HasMaxLength(50);

            this.Property(t => t.QQ)
                .HasMaxLength(50);

            this.Property(t => t.MSN)
                .HasMaxLength(50);

            this.Property(t => t.Blog)
                .HasMaxLength(200);

            this.Property(t => t.mBlog)
                .HasMaxLength(200);

            this.Property(t => t.Team)
                .HasMaxLength(200);

            this.Property(t => t.Eid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("employee");
            this.Property(t => t.BtypeID).HasColumnName("BtypeID");
            this.Property(t => t.typeId).HasColumnName("typeId");
            this.Property(t => t.Parid).HasColumnName("Parid");
            this.Property(t => t.leveal).HasColumnName("leveal");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.Department).HasColumnName("Department");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Nation).HasColumnName("Nation");
            this.Property(t => t.Knowledge).HasColumnName("Knowledge");
            this.Property(t => t.Blood).HasColumnName("Blood");
            this.Property(t => t.Health).HasColumnName("Health");
            this.Property(t => t.IDcard).HasColumnName("IDcard");
            this.Property(t => t.Birthday).HasColumnName("Birthday");
            this.Property(t => t.Marriage).HasColumnName("Marriage");
            this.Property(t => t.Job).HasColumnName("Job");
            this.Property(t => t.Job2).HasColumnName("Job2");
            this.Property(t => t.JobTime).HasColumnName("JobTime");
            this.Property(t => t.Tel2).HasColumnName("Tel2");
            this.Property(t => t.Mob).HasColumnName("Mob");
            this.Property(t => t.Mail).HasColumnName("Mail");
            this.Property(t => t.political).HasColumnName("political");
            this.Property(t => t.nat_place).HasColumnName("nat_place");
            this.Property(t => t.college).HasColumnName("college");
            this.Property(t => t.for_language).HasColumnName("for_language");
            this.Property(t => t.reg_place).HasColumnName("reg_place");
            this.Property(t => t.com_level).HasColumnName("com_level");
            this.Property(t => t.weight).HasColumnName("weight");
            this.Property(t => t.stature).HasColumnName("stature");
            this.Property(t => t.fam_status).HasColumnName("fam_status");
            this.Property(t => t.informer).HasColumnName("informer");
            this.Property(t => t.speciality).HasColumnName("speciality");
            this.Property(t => t.for_lan_level).HasColumnName("for_lan_level");
            this.Property(t => t.PostCode).HasColumnName("PostCode");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.DtypeID).HasColumnName("DtypeID");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.MaxPre).HasColumnName("MaxPre");
            this.Property(t => t.smsMobile).HasColumnName("smsMobile");
            this.Property(t => t.smsComment).HasColumnName("smsComment");
            this.Property(t => t.tichengRate).HasColumnName("tichengRate");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.QQ).HasColumnName("QQ");
            this.Property(t => t.MSN).HasColumnName("MSN");
            this.Property(t => t.Blog).HasColumnName("Blog");
            this.Property(t => t.mBlog).HasColumnName("mBlog");
            this.Property(t => t.Team).HasColumnName("Team");
            this.Property(t => t.HrpostionId).HasColumnName("HrpostionId");
            this.Property(t => t.HrPersonStatu).HasColumnName("HrPersonStatu");
            this.Property(t => t.Eid).HasColumnName("Eid");
            this.Property(t => t.IsDownLoad).HasColumnName("IsDownLoad");
        }
    }
}
