using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataBanGiay.Model;
namespace DataBanGiay.Configuration
{
    public class SanPhamCTConfig : IEntityTypeConfiguration<SanPhamChiTiet>
    {
        public void Configure(EntityTypeBuilder<SanPhamChiTiet> builder)
        {
            builder.ToTable("SanPhamCT");
            builder.HasKey(x => x.Id);
            builder.HasOne(p => p.mauSacs).WithMany(p => p.SanPhamChiTiets).HasForeignKey(p => p.IdMauSac);
            builder.HasOne(p => p.theLoais).WithMany(p => p.SanPhamChiTiets).HasForeignKey(p => p.IDLoai);
            builder.HasOne(p => p.hangGiays).WithMany(p => p.SanPhamChiTiets).HasForeignKey(p => p.IdHang);
            builder.HasOne(p => p.sanPhams).WithMany(p => p.SanPhamChiTiets).HasForeignKey(p => p.IdSP);
            builder.HasOne(p => p.chatLieus).WithMany(p => p.sanPhamChiTiets).HasForeignKey(p => p.IdChatLieu);
            builder.Property(p => p.AnhSP).HasColumnType("nvarchar(300)");
        }
    }
}
