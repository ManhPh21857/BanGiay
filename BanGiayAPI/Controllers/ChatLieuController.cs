using Microsoft.AspNetCore.Mvc;
using DataBanGiay.Model;
using DataBanGiay.IRepositorys;
using DataBanGiay.Repositorys;
namespace BanGiayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatLieuController : ControllerBase
    {
        private IAllRepository<ChatLieu> _Irepos;
        private BanGiayDBConText context = new BanGiayDBConText();

        public ChatLieuController()
        {
            AllRepository<ChatLieu> repos = new AllRepository<ChatLieu>(context, context.ChatLieus);
            _Irepos = repos;
        }
        [HttpGet]
        public IEnumerable<ChatLieu> Get()
        {
            return _Irepos.GetAll();
        }

        [HttpPost("Create")]
        public bool CreateColor(string ten, bool trangthai)
        {
            ChatLieu color = new ChatLieu();
            color.TenChatLieu = ten;
            color.TrangThai = trangthai;
            return _Irepos.Create(color);
        }

        [HttpPut("Edit")]
        public bool UpdateColor(int id, string ten, bool trangthai)
        {
            ChatLieu color = _Irepos.GetAll().First(p => p.Id == id);
            color.TenChatLieu = ten;
            color.TrangThai = trangthai;
            return _Irepos.Update(color);
        }

        [HttpDelete("Delete")]
        public bool Delete(int id)
        {
            ChatLieu color = _Irepos.GetAll().First(p => p.Id == id);

            return _Irepos.Delete(color);
        }
    }
}
