using Microsoft.AspNetCore.Mvc;

namespace API_Pagamento.Controllers
{
    public class PayamentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
