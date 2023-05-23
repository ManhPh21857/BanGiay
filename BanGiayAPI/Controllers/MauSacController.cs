using Microsoft.AspNetCore.Mvc;
using DataBanGiay.Model;
using DataBanGiay.IRepositorys;
using DataBanGiay.Repositorys;
namespace BanGiayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MauSacController : ControllerBase
    {
        private IAllRepository<MauSac> _Irepos;
        private BanGiayDBConText context = new BanGiayDBConText();

        public MauSacController()
        {
            AllRepository<MauSac> repos = new AllRepository<MauSac>(context, context.MauSacs);
            _Irepos = repos;
        }
        [HttpGet]
        public IEnumerable<MauSac> Get()
        {
            return _Irepos.GetAll();
        }


        // POST api/<MauSacController>
        [HttpPost("Create")]

        public bool CreateColor(string ten, bool trangthai)
        {
            MauSac color = new MauSac();
            color.TenMau = ten;
            color.TrangThai = trangthai;
            return _Irepos.Create(color);
        }

        [HttpPut("Edit")]
        public bool UpdateColor(int id, string ten, bool trangthai)
        {
            MauSac color = _Irepos.GetAll().First(p => p.Id == id);
            color.TenMau = ten;
            color.TrangThai = trangthai;
            return _Irepos.Update(color);
        }

        [HttpDelete("Delete")]
        public bool Delete(int id)
        {
            MauSac color = _Irepos.GetAll().First(p => p.Id == id);

            return _Irepos.Delete(color);
        }
    }
}
