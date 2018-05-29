using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CommonPosInfoMap : EntityTypeConfiguration<CommonPosInfo>
    {
        public CommonPosInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.PosID);

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

            this.Property(t => t.ETypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Stockid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BTypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PosPassword)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.Comment)
                .HasMaxLength(100);

            this.Property(t => t.cBYZD1)
                .HasMaxLength(50);

            this.Property(t => t.cBYZD2)
                .HasMaxLength(50);

            this.Property(t => t.ETypeid1)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CommonPosInfo");
            this.Property(t => t.PosID).HasColumnName("PosID");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.Branchid).HasColumnName("Branchid");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.Stockid).HasColumnName("Stockid");
            this.Property(t => t.BTypeId).HasColumnName("BTypeId");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.IsKeyset).HasColumnName("IsKeyset");
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
            this.Property(t => t.ETypeid1).HasColumnName("ETypeid1");
        }
    }
}
