using Microsoft.EntityFrameworkCore;
using System.Reflection;
using DataBanGiay.Configuration;
namespace DataBanGiay.Model
{
    public partial class BanGiayDBConText : DbContext
    {
        public BanGiayDBConText() { }
        public BanGiayDBConText(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ChatLieu> ChatLieus { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<GioHangChiTiet> GioHangCTs { get; set; }
        public DbSet<HangGiay> HangGiays { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonCTs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<MauSac> MauSacs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<SanPhamChiTiet> SanPhamCTs { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-MANHVT\\SQLEXPRESS;Initial Catalog=BanGiay;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ChucVuConfig());
            modelBuilder.ApplyConfiguration(new GioHangConfig());
            modelBuilder.ApplyConfiguration(new GioHangCTConfig());
            modelBuilder.ApplyConfiguration(new HangConfig());
            modelBuilder.ApplyConfiguration(new HoaDonConfig());
            modelBuilder.ApplyConfiguration(new HoaDonCTConfig());
            modelBuilder.ApplyConfiguration(new KhachHangConfig());
            modelBuilder.ApplyConfiguration(new LoaiConfig());
            modelBuilder.ApplyConfiguration(new MauSacConfig());
            modelBuilder.ApplyConfiguration(new NhanVienConfig());
            modelBuilder.ApplyConfiguration(new SanPhamConfig());
            modelBuilder.ApplyConfiguration(new SanPhamCTConfig());
            InsertData(modelBuilder);
        }
        protected void InsertData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>().HasData(
                new ChucVu()
                {
                    Id = 1,
                    TenCV = "Admin",
                },
                new ChucVu()
                {
                    Id = 2,
                    TenCV = "Nhân Viên",
                }
                );

            modelBuilder.Entity<NhanVien>().HasData(
                new NhanVien()
                {
                    Id = 1,
                    IdCV = 1,
                    HovaTen = "Ngô Quốc Mạnh",
                    SDT = "0336253482",
                    NgaySinh = DateTime.Now,
                    DiaChi = "Hà Nội",
                    GioiTinh = false,
                    MatKhau = "123456",
                    TrangThai = true,

                },
                new NhanVien()
                {
                    Id = 2,
                    IdCV = 2,
                    HovaTen = "Trần Quốc Toản",
                    SDT = "0123456789",
                    NgaySinh = DateTime.Now,
                    DiaChi = "Hà Nội",
                    GioiTinh = false,
                    MatKhau = "123456",
                    TrangThai = true,

                }
                );

            modelBuilder.Entity<MauSac>().HasData(
                new MauSac()
                {
                    Id = 1,
                    TenMau = "Đen",
                    TrangThai = true,
                },
                new MauSac()
                {
                    Id = 2,
                    TenMau = "Trắng",
                    TrangThai = true,
                },
                new MauSac()
                {
                    Id = 3,
                    TenMau = "Đen Trắn",
                    TrangThai = true,
                },
                new MauSac()
                {
                    Id = 4,
                    TenMau = "Nâu",
                    TrangThai = true,
                }
                );

            modelBuilder.Entity<HangGiay>().HasData(
                new HangGiay()
                {
                    Id = 1,
                    TenHang = "Sneaker",
                    TrangThai = true
                },
                new HangGiay()
                {
                    Id = 2,
                    TenHang = "Adidas",
                    TrangThai = true
                },
                new HangGiay()
                {
                    Id = 3,
                    TenHang = "Nike",
                    TrangThai = true
                },
                new HangGiay()
                {
                    Id = 4,
                    TenHang = "Converse",
                    TrangThai = true
                },
                new HangGiay()
                {
                    Id = 5,
                    TenHang = "Puma",
                    TrangThai = true
                }
                );

            modelBuilder.Entity<TheLoai>().HasData(
                new TheLoai()
                {
                    Id = 1,
                    LoaiGiay = "Giày Thể Thao",
                    TrangThai = true,
                },
                new TheLoai()
                {
                    Id = 2,
                    LoaiGiay = "Giày Cao Gót",
                    TrangThai = true,
                },
                new TheLoai()
                {
                    Id = 3,
                    LoaiGiay = "Giày sneaker",
                    TrangThai = true,
                },
                new TheLoai()
                {
                    Id = 4,
                    LoaiGiay = "Giày Tây",
                    TrangThai = true,
                });

            modelBuilder.Entity<SanPham>().HasData(
                new SanPham()
                {
                    Id = 1,
                    TenSP = "Giày Jordan Cổ Cao",
                    TrangThai = true
                },
                new SanPham()
                {
                    Id = 2,
                    TenSP = "Giày tây nam Derby GNLA9636-119-D",
                    TrangThai = true
                },
                new SanPham()
                {
                    Id = 3,
                    TenSP = "Giày Cao Gót GU2427",
                    TrangThai = true
                },
                new SanPham()
                {
                    Id = 4,
                    TenSP = "Giày Thể Thao Sneaker",
                    TrangThai = true
                }
                );

            modelBuilder.Entity<ChatLieu>().HasData(
                new ChatLieu()
                {
                    Id = 1,
                    TenChatLieu = "Da",
                    TrangThai = true
                },
                new ChatLieu()
                {
                    Id = 2,
                    TenChatLieu = "Vải",
                    TrangThai = true
                },
                new ChatLieu()
                {
                    Id = 3,
                    TenChatLieu = "Giả da",
                    TrangThai = true
                }
                );

            modelBuilder.Entity<KhachHang>().HasData(
                new KhachHang()
                {
                    Id = 1,
                    HovaTen = "Chuyên Săn Sale",
                    NgaySinh = DateTime.Now,
                    SDT = "0123456788",
                    DiaChi = "Hà Nội",
                    gioitinh = false,
                    MatKhau = "123456",
                    TaiKhoan = "KhachHang01",
                    Diem = 1000

                });

            modelBuilder.Entity<SanPhamChiTiet>().HasData(
                new SanPhamChiTiet()
                {
                    Id = 1,
                    IdMauSac = 2,
                    AnhSP = "https://streetstyleshop.vn/wp-content/uploads/2020/12/giay-cao-got-di-tiec-8-1.jpg",
                    IdChatLieu = 1,
                    SoLuongTon = 20,
                    DonGia = 600000,
                    IdHang = 1,
                    IDLoai = 2,
                    IdSP = 3,
                    Size = 39,
                },
                 new SanPhamChiTiet()
                 {
                     Id = 2,
                     IdMauSac = 3,
                     AnhSP = "https://product.hstatic.net/200000641225/product/0f0a5211_383ec08839f34720afb1578c08f5df80_master.jpg",
                     IdChatLieu = 2,
                     SoLuongTon = 20,
                     DonGia = 500000,
                     IdHang = 1,
                     IDLoai = 3,
                     IdSP = 4,
                     Size = 37,
                 },
                  new SanPhamChiTiet()
                  {
                      Id = 3,
                      IdMauSac = 2,
                      AnhSP = "https://streetstyleshop.vn/wp-content/uploads/2020/12/giay-cao-got-di-tiec-8-1.jpg",
                      IdChatLieu = 1,
                      SoLuongTon = 20,
                      DonGia = 600000,
                      IdHang = 1,
                      IDLoai = 2,
                      IdSP = 3,
                      Size = 32,
                  },
                   new SanPhamChiTiet()
                   {
                       Id = 4,
                       IdMauSac = 1,
                       AnhSP = "https://laforce.vn/wp-content/uploads/2018/12/giay-tay-nam-cong-so-basic-gnla9636-119-d-1-4.jpg",
                       IdChatLieu = 1,
                       SoLuongTon = 20,
                       DonGia = 1800000,
                       IdHang = 1,
                       IDLoai = 4,
                       IdSP = 2,
                       Size = 38,
                   }
                );

        }
    }
}
