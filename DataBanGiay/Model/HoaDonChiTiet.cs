using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBanGiay.Model
{
    public class HoaDonChiTiet
    {
        public int IdHD { get; set; }
        public int IdSPCT { get; set; }
        public int SoLuong { get; set; }
        public string AnhSP { get; set; }
        public int DonGia { get; set; }
        public virtual HoaDon hoaDons { get; set; }
        public virtual SanPhamChiTiet sanPhamChiTiets { get; set; }
    }
}
