using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataBanGiay.Model;
namespace DataBanGiay.Configuration
{
    public class HoaDonConfig : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.Id);
            builder.HasOne(p=>p.nhanViens).WithMany(p=>p.HoaDons).HasForeignKey(p=>p.IdNV);
            builder.HasOne(p => p.khachHangs).WithMany(p => p.HoaDons).HasForeignKey(p => p.IdKH);
        }
    }
}
