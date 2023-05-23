using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBanGiay.Model
{
    public class GioHang
    {
        public int IdNV { get; set; }
        public virtual NhanVien NhanViens { get; set; }
        public virtual List<GioHangChiTiet> GioHangChiTiets { get; set; }
    }
}
