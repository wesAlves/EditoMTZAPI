using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EditoMTZAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EbooksController : ControllerBase
    {
        [HttpGet]
        public string ListAll()
        {
            return "hello world";
        }

        [HttpPost]
        public string Create()
        {
            return "Posting something";
        }
    }
}