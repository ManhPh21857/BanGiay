using Microsoft.AspNetCore.Mvc;
using DataBanGiay.Model;
using DataBanGiay.IRepositorys;
using DataBanGiay.Repositorys;

namespace BanGiayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangGiayController : ControllerBase
    {
        private IAllRepository<HangGiay> _Irepos;
        private BanGiayDBConText context = new BanGiayDBConText();

        public HangGiayController()
        {
            AllRepository<HangGiay> repos = new AllRepository<HangGiay>(context, context.HangGiays);
            _Irepos = repos;
        }
        [HttpGet]
        public IEnumerable<HangGiay> Get()
        {
            return _Irepos.GetAll();
        }

        [HttpPost("Create")]
        public bool CreateColor(string ten, bool trangthai)
        {
            HangGiay color = new HangGiay();
            color.TenHang = ten;
            color.TrangThai = trangthai;
            return _Irepos.Create(color);
        }

        [HttpPut("Edit")]
        public bool UpdateColor(int id, string ten, bool trangthai)
        {
            HangGiay color = _Irepos.GetAll().First(p => p.Id == id);
            color.TenHang = ten;
            color.TrangThai = trangthai;
            return _Irepos.Update(color);
        }

        [HttpDelete("Delete")]
        public bool Delete(int id)
        {
            HangGiay color = _Irepos.GetAll().First(p => p.Id == id);

            return _Irepos.Delete(color);
        }
    }
}
