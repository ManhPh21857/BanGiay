using Microsoft.AspNetCore.Mvc;
using DataBanGiay.Model;
using DataBanGiay.IRepositorys;
using DataBanGiay.Repositorys;
namespace BanGiayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private IAllRepository<SanPham> _Irepos;
        private BanGiayDBConText context = new BanGiayDBConText();

        public SanPhamController()
        {
            AllRepository<SanPham> repos = new AllRepository<SanPham>(context, context.SanPhams);
            _Irepos = repos;
        }
        [HttpGet]
        public IEnumerable<SanPham> Get()
        {
            return _Irepos.GetAll();
        }


        // POST api/<MauSacController>
        [HttpPost("Create")]

        public bool CreateColor(string ten, bool trangthai)
        {
            SanPham color = new SanPham();
            color.TenSP = ten;
            color.TrangThai = trangthai;
            return _Irepos.Create(color);
        }

        [HttpPut("Edit")]
        public bool UpdateColor(int id, string ten, bool trangthai)
        {
            SanPham color = _Irepos.GetAll().First(p => p.Id == id);
            color.TenSP = ten;
            color.TrangThai = trangthai;
            return _Irepos.Update(color);
        }

        [HttpDelete("Delete")]
        public bool Delete(int id)
        {
            SanPham color = _Irepos.GetAll().First(p => p.Id == id);

            return _Irepos.Delete(color);
        }
    }
}
