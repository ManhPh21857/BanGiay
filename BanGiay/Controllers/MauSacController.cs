using Microsoft.AspNetCore.Mvc;
using DataBanGiay.Model;
using Newtonsoft.Json;
namespace BanGiay.Controllers
{
    public class MauSacController : Controller
    {
        public MauSacController()
        {

        }
        public async Task<IActionResult> ShowAllMauSac()
        {
            string apiUrl = "https://localhost:7278/api/MauSac";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(apiUrl);    
            string apiData = await response.Content.ReadAsStringAsync();
            var colors = JsonConvert.DeserializeObject<List<MauSac>>(apiData);
            return View(colors);
        }
    }
}
