using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class ManjiujianMap : EntityTypeConfiguration<Manjiujian>
    {
        public ManjiujianMap()
        {
            this.ToTable("Manjiujian");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.LimitMoney).HasColumnName("LimitMoney");
            this.Property(t => t.LessMoeny).HasColumnName("LessMoeny");
            this.Property(t => t.UserTypes).HasColumnName("UserTypes");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
        }
    }
}
