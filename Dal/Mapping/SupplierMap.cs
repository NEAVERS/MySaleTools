using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class SupplierMap : EntityTypeConfiguration<Supplier>
    {
        public SupplierMap()
        {
            this.HasKey(t => t.Id);
            this.ToTable("Supplier");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.SupplierNum).HasColumnName("SupplierNum");
            this.Property(t => t.SupplierName).HasColumnName("SupplierName");
            this.Property(t => t.SupplierCompany).HasColumnName("SupplierCompany");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.CreateUserName).HasColumnName("CreateUserName");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.Addr).HasColumnName("Addr");

            
        }
    }
}
