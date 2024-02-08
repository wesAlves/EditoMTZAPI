using Microsoft.AspNetCore.Mvc;

namespace EditoMTZAPI.Controllers;

public class Ebooks : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}