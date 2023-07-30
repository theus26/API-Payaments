
using API_Pagamento.DTO;
using API_Pagamento.Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_Pagamento.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PayamentController : ControllerBase
    {
        /// <summary>
        /// Adicionando injeção de independencia para podermos acessar os metodos da Interface e da classe IPayamentValidate 
        /// </summary>
        private readonly IPayamentValidate _payamentValidate;
        public PayamentController(IPayamentValidate payamentValidate)
        {
            _payamentValidate = payamentValidate;
        }


        /// <summary>
        /// Metodo criado para testar a vida e funcionamento da API, antes de realizar as chamadas principais 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult HelthCheck()
        {
            return Ok("I'm alive and working");
        }

        /// <summary>
        /// Esse metodo recebemos os dados do usuario e chamamos o manager, onde sera validado a entrada de dados e será trazido um
        /// um retorno, verificando se a compra pode prosseguir ou não.
        /// </summary>
        /// <param name="payament"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Compras(PayamentDTO payament)
        {
            //Adicionado try e o catch para poder capturar qualquer exceção que ocorra.
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
