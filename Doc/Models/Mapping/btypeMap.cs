using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class btypeMap : EntityTypeConfiguration<btype>
    {
        public btypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.leveal, t.soncount, t.sonnum, t.FullName, t.deleted, t.PriceTrackEnable, t.CanNotModifyPrice, t.Bid });

            // Properties
            this.Property(t => t.typeId)
                .HasMaxLength(50);

            this.Property(t => t.parid)
                .HasMaxLength(50);

            this.Property(t => t.leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.soncount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sonnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserCode)
                .HasMaxLength(26);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.Name)
                .HasMaxLength(30);

            this.Property(t => t.Area)
                .HasMaxLength(30);

            this.Property(t => t.TelAndAddress)
                .HasMaxLength(256);

            this.Property(t => t.PostCode)
                .HasMaxLength(200);

            this.Property(t => t.Person)
                .HasMaxLength(20);

            this.Property(t => t.TaxNumber)
                .HasMaxLength(20);

            this.Property(t => t.BankAndAcount)
                .HasMaxLength(66);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.initcomment)
                .HasMaxLength(500);

            this.Property(t => t.arapexplain)
                .HasMaxLength(2000);

            this.Property(t => t.Tel1)
                .HasMaxLength(50);

            this.Property(t => t.Tel2)
                .HasMaxLength(50);

            this.Property(t => t.Tel3)
                .HasMaxLength(50);

            this.Property(t => t.Fax)
                .HasMaxLength(50);

            this.Property(t => t.WWW)
                .HasMaxLength(50);

            this.Property(t => t.Bank)
                .HasMaxLength(50);

            this.Property(t => t.BankName)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.LinkMan1)
                .HasMaxLength(50);

            this.Property(t => t.LinkJob1)
                .HasMaxLength(50);

            this.Property(t => t.LinkCall1)
                .HasMaxLength(50);

            this.Property(t => t.LinkTel1)
                .HasMaxLength(50);

            this.Property(t => t.LinkMobile1)
                .HasMaxLength(50);

            this.Property(t => t.LinkPost1)
                .HasMaxLength(10);

            this.Property(t => t.LinkAddress1)
                .HasMaxLength(256);

            this.Property(t => t.LinkEmail1)
                .HasMaxLength(50);

            this.Property(t => t.LinkComment1)
                .HasMaxLength(256);

            this.Property(t => t.LinkMan2)
                .HasMaxLength(50);

            this.Property(t => t.LinkJob2)
                .HasMaxLength(50);

            this.Property(t => t.LinkCall2)
                .HasMaxLength(50);

            this.Property(t => t.LinkTel2)
                .HasMaxLength(50);

            this.Property(t => t.LinkMobile2)
                .HasMaxLength(50);

            this.Property(t => t.LinkPost2)
                .HasMaxLength(10);

            this.Property(t => t.LinkAddress2)
                .HasMaxLength(256);

            this.Property(t => t.LinkEmail2)
                .HasMaxLength(50);

            this.Property(t => t.LinkComment2)
                .HasMaxLength(256);

            this.Property(t => t.PyCode)
                .HasMaxLength(500);

            this.Property(t => t.Price)
                .HasMaxLength(50);

            this.Property(t => t.AreaTypeID)
                .HasMaxLength(50);

            this.Property(t => t.smsMobile)
                .HasMaxLength(50);

            this.Property(t => t.smsComment)
                .HasMaxLength(256);

            this.Property(t => t.PriceTrackEnable)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.buyprice)
                .HasMaxLength(50);

            this.Property(t => t.ConsigneeAddress)
                .HasMaxLength(1000);

            this.Property(t => t.Consignee)
                .HasMaxLength(100);

            this.Property(t => t.ConsigneeTel)
                .HasMaxLength(100);

            this.Property(t => t.denominatedid)
                .HasMaxLength(50);

            this.Property(t => t.Bid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("btype");
            this.Property(t => t.typeId).HasColumnName("typeId");
            this.Property(t => t.parid).HasColumnName("parid");
            this.Property(t => t.leveal).HasColumnName("leveal");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.TelAndAddress).HasColumnName("TelAndAddress");
            this.Property(t => t.PostCode).HasColumnName("PostCode");
            this.Property(t => t.Person).HasColumnName("Person");
            this.Property(t => t.TaxNumber).HasColumnName("TaxNumber");
            this.Property(t => t.BankAndAcount).HasColumnName("BankAndAcount");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ARTotal).HasColumnName("ARTotal");
            this.Property(t => t.APTotal).HasColumnName("APTotal");
            this.Property(t => t.ARTotal00).HasColumnName("ARTotal00");
            this.Property(t => t.APTotal00).HasColumnName("APTotal00");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.Client).HasColumnName("Client");
            this.Property(t => t.ARLimit).HasColumnName("ARLimit");
            this.Property(t => t.initcomment).HasColumnName("initcomment");
            this.Property(t => t.arapexplain).HasColumnName("arapexplain");
            this.Property(t => t.Tel1).HasColumnName("Tel1");
            this.Property(t => t.Tel2).HasColumnName("Tel2");
            this.Property(t => t.Tel3).HasColumnName("Tel3");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.WWW).HasColumnName("WWW");
            this.Property(t => t.Bank).HasColumnName("Bank");
            this.Property(t => t.BankName).HasColumnName("BankName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.LinkMan1).HasColumnName("LinkMan1");
            this.Property(t => t.LinkSex1).HasColumnName("LinkSex1");
            this.Property(t => t.LinkBirthDay1).HasColumnName("LinkBirthDay1");
            this.Property(t => t.LinkJob1).HasColumnName("LinkJob1");
            this.Property(t => t.LinkCall1).HasColumnName("LinkCall1");
            this.Property(t => t.LinkTel1).HasColumnName("LinkTel1");
            this.Property(t => t.LinkMobile1).HasColumnName("LinkMobile1");
            this.Property(t => t.LinkPost1).HasColumnName("LinkPost1");
            this.Property(t => t.LinkAddress1).HasColumnName("LinkAddress1");
            this.Property(t => t.LinkEmail1).HasColumnName("LinkEmail1");
            this.Property(t => t.LinkComment1).HasColumnName("LinkComment1");
            this.Property(t => t.LinkMan2).HasColumnName("LinkMan2");
            this.Property(t => t.LinkSex2).HasColumnName("LinkSex2");
            this.Property(t => t.LinkBirthDay2).HasColumnName("LinkBirthDay2");
            this.Property(t => t.LinkJob2).HasColumnName("LinkJob2");
            this.Property(t => t.LinkCall2).HasColumnName("LinkCall2");
            this.Property(t => t.LinkTel2).HasColumnName("LinkTel2");
            this.Property(t => t.LinkMobile2).HasColumnName("LinkMobile2");
            this.Property(t => t.LinkPost2).HasColumnName("LinkPost2");
            this.Property(t => t.LinkAddress2).HasColumnName("LinkAddress2");
            this.Property(t => t.LinkEmail2).HasColumnName("LinkEmail2");
            this.Property(t => t.LinkComment2).HasColumnName("LinkComment2");
            this.Property(t => t.ARLimitTime).HasColumnName("ARLimitTime");
            this.Property(t => t.paymentLTime).HasColumnName("paymentLTime");
            this.Property(t => t.SaleZekou).HasColumnName("SaleZekou");
            this.Property(t => t.BuyZekou).HasColumnName("BuyZekou");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.AreaTypeID).HasColumnName("AreaTypeID");
            this.Property(t => t.smsMobile).HasColumnName("smsMobile");
            this.Property(t => t.smsComment).HasColumnName("smsComment");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.PriceTrackEnable).HasColumnName("PriceTrackEnable");
            this.Property(t => t.cqdays).HasColumnName("cqdays");
            this.Property(t => t.chkskmonthday).HasColumnName("chkskmonthday");
            this.Property(t => t.skmonthday).HasColumnName("skmonthday");
            this.Property(t => t.chkfkmonthday).HasColumnName("chkfkmonthday");
            this.Property(t => t.fkmonthday).HasColumnName("fkmonthday");
            this.Property(t => t.dzdays).HasColumnName("dzdays");
            this.Property(t => t.dzwarningdays).HasColumnName("dzwarningdays");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.buyprice).HasColumnName("buyprice");
            this.Property(t => t.ConsigneeAddress).HasColumnName("ConsigneeAddress");
            this.Property(t => t.Consignee).HasColumnName("Consignee");
            this.Property(t => t.ConsigneeTel).HasColumnName("ConsigneeTel");
            this.Property(t => t.CanNotModifyPrice).HasColumnName("CanNotModifyPrice");
            this.Property(t => t.BackLimitDay).HasColumnName("BackLimitDay");
            this.Property(t => t.BackPercent).HasColumnName("BackPercent");
            this.Property(t => t.denominatedid).HasColumnName("denominatedid");
            this.Property(t => t.Bid).HasColumnName("Bid");
            this.Property(t => t.ckarlimittime).HasColumnName("ckarlimittime");
            this.Property(t => t.ckpaymentltime).HasColumnName("ckpaymentltime");
            this.Property(t => t.fkcqdays).HasColumnName("fkcqdays");
            this.Property(t => t.fkdzdays).HasColumnName("fkdzdays");
            this.Property(t => t.fkdzwarningdays).HasColumnName("fkdzwarningdays");
        }
    }
}
