using Model.Erp;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping.Erp
{
    public class StockMap : EntityTypeConfiguration<Stock>
    {
        public StockMap()
        {
            this.HasKey(x => x.typeId);
            this.ToTable("Stock");
            this.Property(t => t.typeId).HasColumnName("typeId");
            this.Property(t => t.parid).HasColumnName("parid");
            this.Property(t => t.leveal).HasColumnName("leveal");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.Add).HasColumnName("Add");
            this.Property(t => t.Tel).HasColumnName("Tel");


            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.Kid).HasColumnName("Kid");


        }
    }
}
