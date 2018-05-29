using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosPtypeViewMap : EntityTypeConfiguration<PosPtypeView>
    {
        public PosPtypeViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Leveal, t.Sonnum, t.soncount, t.FullName, t.relprice, t.retailprice, t.Deleted, t.stop, t.iBYZD1, t.iBYZD2, t.nBYZD1, t.nBYZD2 });

            // Properties
            this.Property(t => t.Ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.batchNumber)
                .HasMaxLength(30);

            this.Property(t => t.WareNumber)
                .HasMaxLength(30);

            this.Property(t => t.Parid)
                .HasMaxLength(50);

            this.Property(t => t.Leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sonnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.soncount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.standard)
                .HasMaxLength(200);

            this.Property(t => t.type)
                .HasMaxLength(200);

            this.Property(t => t.area)
                .HasMaxLength(200);

            this.Property(t => t.unit)
                .HasMaxLength(8);

            this.Property(t => t.relprice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.retailprice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.stop)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IssueDate)
                .HasMaxLength(30);

            this.Property(t => t.cBYZD1)
                .HasMaxLength(30);

            this.Property(t => t.cBYZD2)
                .HasMaxLength(30);

            this.Property(t => t.iBYZD1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.iBYZD2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nBYZD1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nBYZD2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosPtypeView");
            this.Property(t => t.Ptypeid).HasColumnName("Ptypeid");
            this.Property(t => t.batchNumber).HasColumnName("batchNumber");
            this.Property(t => t.WareNumber).HasColumnName("WareNumber");
            this.Property(t => t.Parid).HasColumnName("Parid");
            this.Property(t => t.Leveal).HasColumnName("Leveal");
            this.Property(t => t.Sonnum).HasColumnName("Sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.standard).HasColumnName("standard");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.area).HasColumnName("area");
            this.Property(t => t.unit).HasColumnName("unit");
            this.Property(t => t.relprice).HasColumnName("relprice");
            this.Property(t => t.retailprice).HasColumnName("retailprice");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.stop).HasColumnName("stop");
            this.Property(t => t.stopdate).HasColumnName("stopdate");
            this.Property(t => t.IssueDate).HasColumnName("IssueDate");
            this.Property(t => t.UpdateTag).HasColumnName("UpdateTag");
            this.Property(t => t.cBYZD1).HasColumnName("cBYZD1");
            this.Property(t => t.cBYZD2).HasColumnName("cBYZD2");
            this.Property(t => t.iBYZD1).HasColumnName("iBYZD1");
            this.Property(t => t.iBYZD2).HasColumnName("iBYZD2");
            this.Property(t => t.nBYZD1).HasColumnName("nBYZD1");
            this.Property(t => t.nBYZD2).HasColumnName("nBYZD2");
        }
    }
}
