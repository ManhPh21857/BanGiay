using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBanGiay.Model
{
    public class NhanVien
    {
        public int Id { get; set; }
        public int IdCV { get; set; }
        public string HovaTen { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string MatKhau { get; set; }
        public bool TrangThai { get; set; }
        public virtual List<HoaDon> HoaDons { get; set; }
        public virtual List<GioHang> GioHangs { get; set; }
        public ChucVu chucVus { get; set; }

    }
}
