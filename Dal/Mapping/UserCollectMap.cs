using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class UserCollectMap : EntityTypeConfiguration<UserCollect>
    {
        public UserCollectMap()
        {
            this.HasKey(t => t.Id);
            this.ToTable("UserCollect");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.GoodsId).HasColumnName("GoodsId");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
        }
    }
}
