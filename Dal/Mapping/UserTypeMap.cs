using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    
    class UserTypeMap : EntityTypeConfiguration<UserType>
    {
        public UserTypeMap()
        {
            this.HasKey(x => x.TypeId);
            this.ToTable("UserType");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
        }
    }
}
