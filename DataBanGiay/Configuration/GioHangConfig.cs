using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataBanGiay.Model;
namespace DataBanGiay.Configuration
{
    public class GioHangConfig : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.ToTable("GioHang");
            builder.HasKey(p => p.IdNV);
            builder.HasOne(p=>p.NhanViens).WithMany(p=>p.GioHangs).HasForeignKey(p=>p.IdNV);
        }
    }
}
