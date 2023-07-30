
using API_Pagamento.DTO;
using API_Pagamento.Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_Pagamento.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PayamentController : ControllerBase
    {
        private readonly IPayamentValidate

        [HttpGet]
        public IActionResult HelthCheck()
        {
            return Ok("I'm alive and working");
        }

        [HttpPost]
        public IActionResult Compras(PayamentDTO payament)
        {
            return Ok(payament);
        }
    }
}
