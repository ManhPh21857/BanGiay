using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataBanGiay.Model;
namespace DataBanGiay.Configuration
{
    public class HangConfig : IEntityTypeConfiguration<HangGiay>
    {
        public void Configure(EntityTypeBuilder<HangGiay> builder)
        {
            builder.ToTable("HangGiay");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TenHang).HasColumnType("nvarchar(50)");

        }
    }
}
