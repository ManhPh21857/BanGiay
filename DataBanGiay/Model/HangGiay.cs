using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBanGiay.Model
{
    public class HangGiay
    {
        public int Id { get; set; }
        public string TenHang { get; set; }
        public bool TrangThai { get; set; }
        public virtual List<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
