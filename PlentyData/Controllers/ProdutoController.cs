using Microsoft.AspNetCore.Mvc;

namespace PlentyData.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
