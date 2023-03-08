using Microsoft.AspNetCore.Mvc;

namespace Platform_Movies.Controllers
{
    public class GenreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
