using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    class UserResourseMap : EntityTypeConfiguration<UserResourse>
    {
        public UserResourseMap()
        {
            this.ToTable("UserResourse");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Resourse).HasColumnName("Resourse");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
