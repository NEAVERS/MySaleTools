using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosInfoMap : EntityTypeConfiguration<PosInfo>
    {
        public PosInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PosID, t.PassType, t.canclezeroway, t.canclezerotype, t.lowlowestsaleprice, t.lowlastbuyprice, t.highhighestsaleprice, t.codesearchway, t.stockqueryrange, t.permitmakevipcard, t.permitvipcardrecharge, t.permitshowbatchno, t.permitshowbatchtime, t.permitsavenonnumber, t.autoshowpromote, t.rememberemployee, t.rateid, t.startbankrate, t.PriceBillIndexID, t.samegoodsumqty, t.permitsaleemployee, t.displayadvpic, t.displayptypepic, t.frequencysecond });

            // Properties
            this.Property(t => t.PosID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .HasMaxLength(200);

            this.Property(t => t.ktypeid)
                .HasMaxLength(50);

            this.Property(t => t.stypeid)
                .HasMaxLength(50);

            this.Property(t => t.BtypeID)
                .HasMaxLength(50);

            this.Property(t => t.MacAddress)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.PyCode)
                .HasMaxLength(100);

            this.Property(t => t.PassType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.canclezeroway)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.canclezerotype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.lowlowestsaleprice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.lowlastbuyprice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.highhighestsaleprice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.codesearchway)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.stockqueryrange)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.permitmakevipcard)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.permitvipcardrecharge)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.permitshowbatchno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.permitshowbatchtime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.permitsavenonnumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.autoshowpromote)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rememberemployee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.rateid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.startbankrate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PriceBillIndexID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.samegoodsumqty)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.permitsaleemployee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.displayadvpic)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.displayptypepic)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.frequencysecond)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosInfo");
            this.Property(t => t.PosID).HasColumnName("PosID");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.ktypeid).HasColumnName("ktypeid");
            this.Property(t => t.stypeid).HasColumnName("stypeid");
            this.Property(t => t.BtypeID).HasColumnName("BtypeID");
            this.Property(t => t.BankCardID).HasColumnName("BankCardID");
            this.Property(t => t.CashID).HasColumnName("CashID");
            this.Property(t => t.VIPMoneyID).HasColumnName("VIPMoneyID");
            this.Property(t => t.IsBinding).HasColumnName("IsBinding");
            this.Property(t => t.MacAddress).HasColumnName("MacAddress");
            this.Property(t => t.STATE).HasColumnName("STATE");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.PassType).HasColumnName("PassType");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.canclezeroway).HasColumnName("canclezeroway");
            this.Property(t => t.canclezerotype).HasColumnName("canclezerotype");
            this.Property(t => t.lowlowestsaleprice).HasColumnName("lowlowestsaleprice");
            this.Property(t => t.lowlastbuyprice).HasColumnName("lowlastbuyprice");
            this.Property(t => t.highhighestsaleprice).HasColumnName("highhighestsaleprice");
            this.Property(t => t.codesearchway).HasColumnName("codesearchway");
            this.Property(t => t.stockqueryrange).HasColumnName("stockqueryrange");
            this.Property(t => t.permitmakevipcard).HasColumnName("permitmakevipcard");
            this.Property(t => t.permitvipcardrecharge).HasColumnName("permitvipcardrecharge");
            this.Property(t => t.permitshowbatchno).HasColumnName("permitshowbatchno");
            this.Property(t => t.permitshowbatchtime).HasColumnName("permitshowbatchtime");
            this.Property(t => t.permitsavenonnumber).HasColumnName("permitsavenonnumber");
            this.Property(t => t.autoshowpromote).HasColumnName("autoshowpromote");
            this.Property(t => t.rememberemployee).HasColumnName("rememberemployee");
            this.Property(t => t.KID).HasColumnName("KID");
            this.Property(t => t.rateid).HasColumnName("rateid");
            this.Property(t => t.startbankrate).HasColumnName("startbankrate");
            this.Property(t => t.PriceBillIndexID).HasColumnName("PriceBillIndexID");
            this.Property(t => t.samegoodsumqty).HasColumnName("samegoodsumqty");
            this.Property(t => t.permitsaleemployee).HasColumnName("permitsaleemployee");
            this.Property(t => t.displayadvpic).HasColumnName("displayadvpic");
            this.Property(t => t.displayptypepic).HasColumnName("displayptypepic");
            this.Property(t => t.frequencysecond).HasColumnName("frequencysecond");
        }
    }
}
