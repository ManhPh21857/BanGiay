using Microsoft.EntityFrameworkCore;
using DataBanGiay.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataBanGiay.Configuration
{
    public class KhachHangConfig : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.HovaTen).HasColumnType("nvarchar(50)");
            builder.Property(p => p.SDT).HasColumnType("nvarchar(10)");
            builder.Property(p => p.MatKhau).HasColumnType("nvarchar(16)");
            builder.Property(p => p.TaiKhoan).HasColumnType("nvarchar(20)");
        }
    }
}
