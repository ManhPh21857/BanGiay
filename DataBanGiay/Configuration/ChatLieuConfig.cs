using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataBanGiay.Model;
namespace DataBanGiay.Configuration
{
    public class ChatLieuConfig : IEntityTypeConfiguration<ChatLieu>
    {
        public void Configure(EntityTypeBuilder<ChatLieu> builder)
        {
            builder.ToTable("ChatLieu");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TenChatLieu).HasColumnType("nvarchar(50)");
        }
    }
}
