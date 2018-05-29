using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosInfoViewMap : EntityTypeConfiguration<PosInfoView>
    {
        public PosInfoViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PosID, t.FullName, t.Branchid, t.stockid, t.Btypeid, t.Deleted, t.isKeySet, t.IsHeadquartersStock, t.IsJoinStock, t.PosPassword, t.Possessive, t.IsTicketCount, t.iBYZD1, t.iBYZD2, t.nBYZD1, t.nBYZD2 });

            // Properties
            this.Property(t => t.PosID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.UserCode)
                .HasMaxLength(26);

            this.Property(t => t.Branchid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Etypeid)
                .HasMaxLength(50);

            this.Property(t => t.stockid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Btypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Deleted)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.isKeySet)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsHeadquartersStock)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsJoinStock)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PosPassword)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.Possessive)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(100);

            this.Property(t => t.IsTicketCount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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
            this.ToTable("PosInfoView");
            this.Property(t => t.PosID).HasColumnName("PosID");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.Branchid).HasColumnName("Branchid");
            this.Property(t => t.Etypeid).HasColumnName("Etypeid");
            this.Property(t => t.stockid).HasColumnName("stockid");
            this.Property(t => t.Btypeid).HasColumnName("Btypeid");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.isKeySet).HasColumnName("isKeySet");
            this.Property(t => t.IsHeadquartersStock).HasColumnName("IsHeadquartersStock");
            this.Property(t => t.IsJoinStock).HasColumnName("IsJoinStock");
            this.Property(t => t.PosPassword).HasColumnName("PosPassword");
            this.Property(t => t.Possessive).HasColumnName("Possessive");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.IsTicketCount).HasColumnName("IsTicketCount");
            this.Property(t => t.cBYZD1).HasColumnName("cBYZD1");
            this.Property(t => t.cBYZD2).HasColumnName("cBYZD2");
            this.Property(t => t.iBYZD1).HasColumnName("iBYZD1");
            this.Property(t => t.iBYZD2).HasColumnName("iBYZD2");
            this.Property(t => t.nBYZD1).HasColumnName("nBYZD1");
            this.Property(t => t.nBYZD2).HasColumnName("nBYZD2");
        }
    }
}
