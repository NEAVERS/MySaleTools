using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AccountCredenceMap : EntityTypeConfiguration<AccountCredence>
    {
        public AccountCredenceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberID, t.TypeATypeID, t.ID, t.AlertDay });

            // Properties
            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TypeATypeID)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.ATypeID)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.AlertDay)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AccountCredence");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.TypeATypeID).HasColumnName("TypeATypeID");
            this.Property(t => t.ATypeID).HasColumnName("ATypeID");
            this.Property(t => t.J_Total).HasColumnName("J_Total");
            this.Property(t => t.D_Total).HasColumnName("D_Total");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.TeamNo1).HasColumnName("TeamNo1");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.NJ_Total).HasColumnName("NJ_Total");
            this.Property(t => t.ND_Total).HasColumnName("ND_Total");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.AlertDay).HasColumnName("AlertDay");
        }
    }
}
