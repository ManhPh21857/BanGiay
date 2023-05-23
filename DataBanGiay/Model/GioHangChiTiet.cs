using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBanGiay.Model
{
    public class GioHangChiTiet
    {
        public int Id { get; set; }
        public int IdSPCT { get; set; }
        public int IdNV { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string AnhSP { get; set; }
        public virtual GioHang gioHangs { get; set; }
        public virtual SanPhamChiTiet sanPhamChiTiets { get; set; }
    }
}
