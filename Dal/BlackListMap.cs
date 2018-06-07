using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class BlackListMap : EntityTypeConfiguration<BlackList>
    {
        public BlackListMap()
        {
            this.ToTable("BlackList");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.GoodsId).HasColumnName("GoodsId");
            this.Property(t => t.GoodsName).HasColumnName("GoodsName");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.CreateUserName).HasColumnName("CreateUserName");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");

        }

    }
}
