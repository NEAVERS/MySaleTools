using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{


    public class DPSMap : EntityTypeConfiguration<DPS>
    {
        public DPSMap()
        {
            this.HasKey(t => t.Id);
            this.ToTable("DPS");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.GoodsNum).HasColumnName("GoodsNum");
            this.Property(t => t.GoodsId).HasColumnName("GoodsId");
            this.Property(t => t.GoodsName).HasColumnName("GoodsName");
            this.Property(t => t.Count).HasColumnName("Count");
            this.Property(t => t.SendGoodsNum).HasColumnName("SendGoodsNum");
            this.Property(t => t.SendGoodsId).HasColumnName("SendGoodsId");
            this.Property(t => t.SendGoodsName).HasColumnName("SendGoodsName");
            this.Property(t => t.SendCount).HasColumnName("SendCount");
            this.Property(t => t.IsOnly).HasColumnName("IsOnly");
            this.Property(t => t.IsRepeat).HasColumnName("IsRepeat");
            this.Property(t => t.UserTypes).HasColumnName("UserTypes");
            this.Property(t => t.Areas).HasColumnName("Areas");

            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.CreateUserName).HasColumnName("CreateUserName");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            

        }
    }
}
