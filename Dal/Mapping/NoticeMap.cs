using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class NoticeMap : EntityTypeConfiguration<Notice>
    {
        public NoticeMap()
        {
            this.ToTable("Notice");

            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Tittle).HasColumnName("Tittle");
            this.Property(t => t.Content).HasColumnName("Content");

            this.Property(t => t.UserTypes).HasColumnName("UserTypes");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUserId).HasColumnName("CreateUserId");
            this.Property(t => t.IsDelete).HasColumnName("IsDelete");


        }
        
    }
}
