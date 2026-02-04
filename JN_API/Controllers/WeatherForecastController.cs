using JN_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace JN_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet(Name = "ConsultarDeudaCedula")]
        public IActionResult ConsultarDeudaCedula(string cedula)
        {
            return NotFound("3 deudas");
        }
    }
}