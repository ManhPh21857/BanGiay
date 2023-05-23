using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataBanGiay.Model;
namespace DataBanGiay.Configuration
{
    public class SanPhamConfig : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.Property(p => p.TenSP).HasColumnType("nvarchar(50)");
        }
    }
}
