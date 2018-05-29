using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class HR_ImgMap : EntityTypeConfiguration<HR_Img>
    {
        public HR_ImgMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("HR_Img");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.parID).HasColumnName("parID");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.delete).HasColumnName("delete");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.pic).HasColumnName("pic");
            this.Property(t => t.filename).HasColumnName("filename");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.Person_ID).HasColumnName("Person_ID");
        }
    }
}
