﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBanGiay.Model
{
    public class KhachHang
    {
        public int Id { get; set; }
        public string HovaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public bool gioitinh { get; set; }
        public string MatKhau { get; set; }
        public string TaiKhoan { get; set; }
        public int Diem { get; set; }
        public virtual List<HoaDon> HoaDons { get; set; }
    }
}
