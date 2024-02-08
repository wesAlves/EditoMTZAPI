using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EditoMTZAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EbooksController : ControllerBase
    {
        [HttpGet]
        public string Method()
        {
            return "hello world";
        }
    }
}