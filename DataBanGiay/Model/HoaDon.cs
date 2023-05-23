using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBanGiay.Model
{
    public class HoaDon
    {
        public int Id { get; set; }
        public int IdKH { get; set; }
        public int IdNV { get; set; }
        public DateTime NgayTao { get; set; }
        public bool TrangThai { get; set; }
        public virtual List<HoaDonChiTiet> hoaDonChiTiets { get; set; }
        public virtual NhanVien nhanViens { get; set; }
        public virtual KhachHang khachHangs { get; set; }
    }
}
