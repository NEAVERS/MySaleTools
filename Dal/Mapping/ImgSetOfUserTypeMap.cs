using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    class ImgSetOfUserTypeMap : EntityTypeConfiguration<ImgSetOfUserType>
    {
        public ImgSetOfUserTypeMap()
        {
            this.ToTable("ImgSetOfUserType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserType).HasColumnName("UserType");
            this.Property(t => t.ImgSetId).HasColumnName("ImgSetId");

        }
    }
}
