
using API_Pagamento.DTO;
using API_Pagamento.Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_Pagamento.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PayamentController : ControllerBase
    {
        private readonly IPayamentValidate _payamentValidate;
        public PayamentController(IPayamentValidate payamentValidate)
        {
            _payamentValidate = payamentValidate;
        }

        [HttpGet]
        public IActionResult HelthCheck()
        {
            return Ok("I'm alive and working");
        }

        [HttpPost]
        public IActionResult Compras(PayamentDTO payament)
        {
            try
            {
                var validate = _payamentValidate.Validate(payament);
                return Ok(validate);
            }
           catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new ErrorResponseDTO()
                {
                    status = StatusCodes.Status400BadRequest,
                    message = ex.Message
                   
                });
            }
        }
    }
}
