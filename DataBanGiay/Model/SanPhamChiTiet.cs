using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBanGiay.Model
{
    public class SanPhamChiTiet
    {
        public int Id { get; set; }
        public int IdSP { get; set; }
        public int IDLoai { get; set; }
        public int IdMauSac { get; set; }
        public int IdHang { get; set; }
        public int IdChatLieu { get; set; }
        public int SoLuongTon { get; set; }
        public int DonGia { get; set; }
        public string AnhSP { get; set; }
        public int Size { get; set; }
        public virtual List<GioHangChiTiet> gioHangChiTiets { get; set; }
        public virtual List<HoaDonChiTiet> hoaDonChiTiets { get; set; }
        public virtual SanPham sanPhams { get; set; }
        public virtual MauSac mauSacs { get; set; }
        public virtual HangGiay hangGiays { get; set; }
        public virtual TheLoai theLoais { get; set; }
        public virtual ChatLieu chatLieus { get; set; }
    }
}
