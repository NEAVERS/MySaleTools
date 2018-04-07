using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    public class ImgSetMap : EntityTypeConfiguration<ImgSet>
    {
        public ImgSetMap()
        {
            this.ToTable("ImgSet");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Ttile).HasColumnName("Ttile");
            this.Property(t => t.ImgUrl).HasColumnName("ImgUrl");
            this.Property(t => t.TurnUrl).HasColumnName("TurnUrl");
            this.Property(t => t.ImgType).HasColumnName("ImgType");
            this.Property(t => t.SortedId).HasColumnName("SortedId");
        }
    }
}
