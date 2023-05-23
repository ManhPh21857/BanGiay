using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataBanGiay.Model;
namespace DataBanGiay.Configuration
{
    public class HoaDonCTConfig : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonCT");
            builder.HasKey(p => new { p.IdSPCT, p.IdHD });
            builder.HasOne(p => p.sanPhamChiTiets).WithMany(p=>p.hoaDonChiTiets).HasForeignKey(p => p.IdSPCT);
            builder.HasOne(p=>p.hoaDons).WithMany(p=>p.hoaDonChiTiets).HasForeignKey(p=>p.IdHD);
        }
    }
}
