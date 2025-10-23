using Microsoft.AspNetCore.Mvc;

namespace TreversalRezervasyon.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
