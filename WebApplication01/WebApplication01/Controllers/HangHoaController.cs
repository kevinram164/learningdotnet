using Microsoft.AspNetCore.Mvc;
using WebApplication01.Models;

namespace WebApplication01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoaController : Controller
    {
        public static List<HangHoa> hangHoas = new List<HangHoa>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(hangHoas);
        }

        [HttpPost]
        public IActionResult Create(HangHoaVM HangHoaVM)
        {
            var hanghoa = new HangHoa
            {
                MaHangHoa = Guid.NewGuid(),
                Name = HangHoaVM.Name,
                Price = HangHoaVM.Price
            };
            hangHoas.Add(hanghoa);
            return Ok(new
            {
                Success = true, Data = hanghoa
            }
                );
        }
    }
}
