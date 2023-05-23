using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBanGiay.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChatLieus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChatLieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatLieus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCV = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HangGiay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHang = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangGiay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HovaTen = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioitinh = table.Column<bool>(type: "bit", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(16)", nullable: false),
                    TaiKhoan = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Diem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMau = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiGiay = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCV = table.Column<int>(type: "int", nullable: false),
                    HovaTen = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(16)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdCV",
                        column: x => x.IdCV,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPhamCT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSP = table.Column<int>(type: "int", nullable: false),
                    IDLoai = table.Column<int>(type: "int", nullable: false),
                    IdMauSac = table.Column<int>(type: "int", nullable: false),
                    IdHang = table.Column<int>(type: "int", nullable: false),
                    IdChatLieu = table.Column<int>(type: "int", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<int>(type: "int", nullable: false),
                    AnhSP = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamCT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPhamCT_ChatLieus_IdChatLieu",
                        column: x => x.IdChatLieu,
                        principalTable: "ChatLieus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamCT_HangGiay_IdHang",
                        column: x => x.IdHang,
                        principalTable: "HangGiay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamCT_MauSac_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "MauSac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamCT_SanPham_IdSP",
                        column: x => x.IdSP,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamCT_TheLoai_IDLoai",
                        column: x => x.IDLoai,
                        principalTable: "TheLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    IdNV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.IdNV);
                    table.ForeignKey(
                        name: "FK_GioHang_NhanVien_IdNV",
                        column: x => x.IdNV,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKH = table.Column<int>(type: "int", nullable: false),
                    IdNV = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKH",
                        column: x => x.IdKH,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNV",
                        column: x => x.IdNV,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangCT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSPCT = table.Column<int>(type: "int", nullable: false),
                    IdNV = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    AnhSP = table.Column<string>(type: "nvarchar(300)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangCT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHangCT_GioHang_IdNV",
                        column: x => x.IdNV,
                        principalTable: "GioHang",
                        principalColumn: "IdNV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHangCT_SanPhamCT_IdSPCT",
                        column: x => x.IdSPCT,
                        principalTable: "SanPhamCT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonCT",
                columns: table => new
                {
                    IdHD = table.Column<int>(type: "int", nullable: false),
                    IdSPCT = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    AnhSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonCT", x => new { x.IdSPCT, x.IdHD });
                    table.ForeignKey(
                        name: "FK_HoaDonCT_HoaDon_IdHD",
                        column: x => x.IdHD,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonCT_SanPhamCT_IdSPCT",
                        column: x => x.IdSPCT,
                        principalTable: "SanPhamCT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ChatLieus",
                columns: new[] { "Id", "TenChatLieu", "TrangThai" },
                values: new object[,]
                {
                    { 1, "Da", true },
                    { 2, "Vải", true },
                    { 3, "Giả da", true }
                });

            migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "Id", "TenCV" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Nhân Viên" }
                });

            migrationBuilder.InsertData(
                table: "HangGiay",
                columns: new[] { "Id", "TenHang", "TrangThai" },
                values: new object[,]
                {
                    { 1, "Sneaker", true },
                    { 2, "Adidas", true },
                    { 3, "Nike", true },
                    { 4, "Converse", true },
                    { 5, "Puma", true }
                });

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "Id", "DiaChi", "Diem", "HovaTen", "MatKhau", "NgaySinh", "SDT", "TaiKhoan", "gioitinh" },
                values: new object[] { 1, "Hà Nội", 1000, "Chuyên Săn Sale", "123456", new DateTime(2023, 5, 23, 9, 2, 42, 870, DateTimeKind.Local).AddTicks(1932), "0123456788", "KhachHang01", false });

            migrationBuilder.InsertData(
                table: "MauSac",
                columns: new[] { "Id", "TenMau", "TrangThai" },
                values: new object[,]
                {
                    { 1, "Đen", true },
                    { 2, "Trắng", true },
                    { 3, "Đen Trắn", true },
                    { 4, "Nâu", true }
                });

            migrationBuilder.InsertData(
                table: "SanPham",
                columns: new[] { "Id", "TenSP", "TrangThai" },
                values: new object[,]
                {
                    { 1, "Giày Jordan Cổ Cao", true },
                    { 2, "Giày tây nam Derby GNLA9636-119-D", true },
                    { 3, "Giày Cao Gót GU2427", true },
                    { 4, "Giày Thể Thao Sneaker", true }
                });

            migrationBuilder.InsertData(
                table: "TheLoai",
                columns: new[] { "Id", "LoaiGiay", "TrangThai" },
                values: new object[,]
                {
                    { 1, "Giày Thể Thao", true },
                    { 2, "Giày Cao Gót", true },
                    { 3, "Giày sneaker", true },
                    { 4, "Giày Tây", true }
                });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "Id", "DiaChi", "GioiTinh", "HovaTen", "IdCV", "MatKhau", "NgaySinh", "SDT", "TrangThai" },
                values: new object[,]
                {
                    { 1, "Hà Nội", false, "Ngô Quốc Mạnh", 1, "123456", new DateTime(2023, 5, 23, 9, 2, 42, 870, DateTimeKind.Local).AddTicks(1721), "0336253482", true },
                    { 2, "Hà Nội", false, "Trần Quốc Toản", 2, "123456", new DateTime(2023, 5, 23, 9, 2, 42, 870, DateTimeKind.Local).AddTicks(1745), "0123456789", true }
                });

            migrationBuilder.InsertData(
                table: "SanPhamCT",
                columns: new[] { "Id", "AnhSP", "DonGia", "IDLoai", "IdChatLieu", "IdHang", "IdMauSac", "IdSP", "Size", "SoLuongTon" },
                values: new object[,]
                {
                    { 1, "https://streetstyleshop.vn/wp-content/uploads/2020/12/giay-cao-got-di-tiec-8-1.jpg", 600000, 2, 1, 1, 2, 3, 39, 20 },
                    { 2, "https://product.hstatic.net/200000641225/product/0f0a5211_383ec08839f34720afb1578c08f5df80_master.jpg", 500000, 3, 2, 1, 3, 4, 37, 20 },
                    { 3, "https://streetstyleshop.vn/wp-content/uploads/2020/12/giay-cao-got-di-tiec-8-1.jpg", 600000, 2, 1, 1, 2, 3, 32, 20 },
                    { 4, "https://laforce.vn/wp-content/uploads/2018/12/giay-tay-nam-cong-so-basic-gnla9636-119-d-1-4.jpg", 1800000, 4, 1, 1, 1, 2, 38, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GioHangCT_IdNV",
                table: "GioHangCT",
                column: "IdNV");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangCT_IdSPCT",
                table: "GioHangCT",
                column: "IdSPCT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKH",
                table: "HoaDon",
                column: "IdKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNV",
                table: "HoaDon",
                column: "IdNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCT_IdHD",
                table: "HoaDonCT",
                column: "IdHD");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCV",
                table: "NhanVien",
                column: "IdCV");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCT_IdChatLieu",
                table: "SanPhamCT",
                column: "IdChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCT_IdHang",
                table: "SanPhamCT",
                column: "IdHang");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCT_IDLoai",
                table: "SanPhamCT",
                column: "IDLoai");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCT_IdMauSac",
                table: "SanPhamCT",
                column: "IdMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCT_IdSP",
                table: "SanPhamCT",
                column: "IdSP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHangCT");

            migrationBuilder.DropTable(
                name: "HoaDonCT");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPhamCT");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ChatLieus");

            migrationBuilder.DropTable(
                name: "HangGiay");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "TheLoai");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
