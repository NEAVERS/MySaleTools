using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_WLDZ_GYSMap : EntityTypeConfiguration<vWeb_WLDZ_GYS>
    {
        public vWeb_WLDZ_GYSMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillDate, t.BillCode, t.Id, t.BillNumberID, t.BillType, t.RedWord });

            // Properties
            this.Property(t => t.zy)
                .HasMaxLength(261);

            this.Property(t => t.fullName)
                .HasMaxLength(200);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Btypeid)
                .HasMaxLength(50);

            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RedWord)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vWeb_WLDZ_GYS");
            this.Property(t => t.zy).HasColumnName("zy");
            this.Property(t => t.fullName).HasColumnName("fullName");
            this.Property(t => t.ApAdd).HasColumnName("ApAdd");
            this.Property(t => t.ApReduce).HasColumnName("ApReduce");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Btypeid).HasColumnName("Btypeid");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.TeamNo1).HasColumnName("TeamNo1");
            this.Property(t => t.RedWord).HasColumnName("RedWord");
        }
    }
}
