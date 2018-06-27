using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class DiscountInfoMap : EntityTypeConfiguration<DiscountInfo>
    {
        public DiscountInfoMap()
        {
            this.ToTable("DiscountInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.UserTypes).HasColumnName("UserTypes");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.UpdateUserId).HasColumnName("UpdateUserId");
            this.Property(t => t.UpdateUserName).HasColumnName("UpdateUserName");

            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");


        }
    }

}
