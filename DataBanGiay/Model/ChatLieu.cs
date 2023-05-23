using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBanGiay.Model
{
    public class ChatLieu
    {
        public int Id { get; set; }
        public string TenChatLieu { get; set; }
        public bool TrangThai { get; set; }
        public virtual List<SanPhamChiTiet> sanPhamChiTiets { get; set; }
    }
}
