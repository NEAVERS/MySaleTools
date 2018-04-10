using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping
{
    
    class ErrorReasonMap : EntityTypeConfiguration<ErrorReason>
    {
        public ErrorReasonMap()
        {
            this.HasKey(x => x.Id);
            this.ToTable("ErrorReason");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ErrorCode).HasColumnName("ErrorCode");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.ParentCode).HasColumnName("ParentCode");
            this.Property(t => t.Info).HasColumnName("Info");

        }
    }
}
