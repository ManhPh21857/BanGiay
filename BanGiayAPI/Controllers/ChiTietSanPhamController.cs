using Microsoft.AspNetCore.Mvc;
using DataBanGiay.Model;
using DataBanGiay.IRepositorys;
using DataBanGiay.Repositorys;
namespace BanGiayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChiTietSanPhamController : ControllerBase
    {
        private IAllRepository<SanPhamChiTiet> _Irepos;
        private BanGiayDBConText context = new BanGiayDBConText();

        public ChiTietSanPhamController()
        {
            AllRepository<SanPhamChiTiet> repos = new AllRepository<SanPhamChiTiet>(context, context.SanPhamCTs);
            _Irepos = repos;
        }
        [HttpGet]
        public IEnumerable<SanPhamChiTiet> Get()
        {
            return _Irepos.GetAll();
        }

        [HttpPost("Create")]
        public bool CreateSPCT(int idsp, int idms, int idhang, int idtl, int idcl,int soluongton, int dongia, string anhsp,int size)
        {
            SanPhamChiTiet spct = new SanPhamChiTiet();
            spct.IdMauSac = idms;
            spct.IdSP = idsp;
            spct.IdHang = idhang;
            spct.IDLoai = idtl;
            spct.IdChatLieu = idcl;
            spct.SoLuongTon = soluongton;
            spct.DonGia = dongia;
            spct.AnhSP = anhsp;
            spct.Size = size;
            return _Irepos.Create(spct);
        }

        [HttpPut("Edit")]
        public bool UpdateSPCT(int id, int idsp, int idms, int idhang, int idtl, int idcl, int soluongton, int dongia, string anhsp, int size)
        {
            SanPhamChiTiet spct = _Irepos.GetAll().First(p => p.Id == id);
            spct.IdMauSac = idms;
            spct.IdSP = idsp;
            spct.IdHang = idhang;
            spct.IDLoai = idtl;
            spct.IdChatLieu = idcl;
            spct.SoLuongTon = soluongton;
            spct.DonGia = dongia;
            spct.AnhSP = anhsp;
            spct.Size = size;
            return _Irepos.Update(spct);
        }

        [HttpDelete("Delete")]
        public bool Delete(int id)
        {
            SanPhamChiTiet color = _Irepos.GetAll().First(p => p.Id == id);

            return _Irepos.Delete(color);
        }
    }
}
