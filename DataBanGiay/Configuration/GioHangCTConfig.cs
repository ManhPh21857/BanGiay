using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataBanGiay.Model;
namespace DataBanGiay.Configuration
{
    public class GioHangCTConfig : IEntityTypeConfiguration<GioHangChiTiet>
    {
        public void Configure(EntityTypeBuilder<GioHangChiTiet> builder)
        {
            builder.ToTable("GioHangCT");
            builder.HasKey(x => x.Id);
            builder.HasOne(p => p.sanPhamChiTiets).WithMany(p => p.gioHangChiTiets).HasForeignKey(p => p.IdSPCT);
            builder.HasOne(p=>p.gioHangs).WithMany(p=>p.GioHangChiTiets).HasForeignKey(p=>p.IdNV);
            builder.Property(p => p.AnhSP).HasColumnType("nvarchar(300)");

        }
    }
}
