
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcProject.MODEL.Models;

namespace MvcProject.MAP.Configurations
{
    public class OperationConfiguration : IEntityTypeConfiguration<Operation>
    {
        public void Configure(EntityTypeBuilder<Operation> builder)
        {
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new { x.StudentID, x.BookID });
            builder.HasOne(o => o.Book).WithMany(b => b.Operations).HasForeignKey(o => o.BookID);
            builder.HasOne(o => o.Student).WithMany(s => s.Operations).HasForeignKey(o => o.StudentID);

            //builder.Property(x => x.StartDate).HasColumnName("Baslamatarihi");
            //builder.Ignore("ID");
            //builder.HasKey("StudentID","BookID");

        }
    }
}
