using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataBanGiay.Model;
namespace DataBanGiay.Configuration
{
    public class ChucVuConfig : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.ToTable("ChucVu");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.TenCV).HasColumnType("nvarchar(50)");
        }
    }
}
