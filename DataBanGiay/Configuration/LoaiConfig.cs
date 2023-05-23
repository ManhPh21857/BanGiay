using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataBanGiay.Model;
namespace DataBanGiay.Configuration
{
    public class LoaiConfig : IEntityTypeConfiguration<TheLoai>
    {
        public void Configure(EntityTypeBuilder<TheLoai> builder)
        {
            builder.ToTable("TheLoai");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.LoaiGiay).HasColumnType("nvarchar(50)");
        }
    }
}
