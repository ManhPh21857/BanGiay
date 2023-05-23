using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBanGiay.Model
{
    public class ChucVu
    {
        public int Id { get; set; }
        public string TenCV { get; set; }
        public virtual List<NhanVien> NhanViens { get; set; }
    }
}
