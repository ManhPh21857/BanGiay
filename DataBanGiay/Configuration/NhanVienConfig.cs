using Microsoft.EntityFrameworkCore;
using DataBanGiay.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataBanGiay.Configuration
{
    public class NhanVienConfig : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.Id);
            builder.HasOne(p => p.chucVus).WithMany(p => p.NhanViens).HasForeignKey(p => p.IdCV);
            builder.Property(p => p.HovaTen).HasColumnType("nvarchar(50)");
            builder.Property(p => p.SDT).HasColumnType("nvarchar(10)");
            builder.Property(p => p.MatKhau).HasColumnType("nvarchar(16)");

        }
    }
}
