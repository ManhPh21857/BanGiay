using Microsoft.AspNetCore.Mvc;
using DataBanGiay.Model;
using DataBanGiay.IRepositorys;
using DataBanGiay.Repositorys;

namespace BanGiayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheLoaiController : ControllerBase
    {
        private IAllRepository<TheLoai> _Irepos;
        private BanGiayDBConText context = new BanGiayDBConText();

        public TheLoaiController()
        {
            AllRepository<TheLoai> repos = new AllRepository<TheLoai>(context, context.TheLoais);
            _Irepos = repos;
        }
        [HttpGet]
        public IEnumerable<TheLoai> Get()
        {
            return _Irepos.GetAll();
        }

        [HttpPost("Create")]
        public bool CreateColor(string ten, bool trangthai)
        {
            TheLoai color = new TheLoai();
            color.LoaiGiay = ten;
            color.TrangThai = trangthai;
            return _Irepos.Create(color);
        }

        [HttpPut("Edit")]
        public bool UpdateColor(int id, string ten, bool trangthai)
        {
            TheLoai color = _Irepos.GetAll().First(p => p.Id == id);
            color.LoaiGiay = ten;
            color.TrangThai = trangthai;
            return _Irepos.Update(color);
        }

        [HttpDelete("Delete")]
        public bool Delete(int id)
        {
            TheLoai color = _Irepos.GetAll().First(p => p.Id == id);

            return _Irepos.Delete(color);
        }
    }
}
