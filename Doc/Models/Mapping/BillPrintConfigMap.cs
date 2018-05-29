using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BillPrintConfigMap : EntityTypeConfiguration<BillPrintConfig>
    {
        public BillPrintConfigMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.BillTypes, t.BillType, t.AddState, t.SaveState, t.PassState, t.SaveAlert, t.PassAlert, t.PrintNum, t.SortID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillTypes)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddState)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SaveState)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PassState)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SaveAlert)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PassAlert)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PrintNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SortID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BillPrintConfig");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillTypes).HasColumnName("BillTypes");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.AddState).HasColumnName("AddState");
            this.Property(t => t.SaveState).HasColumnName("SaveState");
            this.Property(t => t.PassState).HasColumnName("PassState");
            this.Property(t => t.SaveAlert).HasColumnName("SaveAlert");
            this.Property(t => t.PassAlert).HasColumnName("PassAlert");
            this.Property(t => t.PrintNum).HasColumnName("PrintNum");
            this.Property(t => t.SortID).HasColumnName("SortID");
        }
    }
}
