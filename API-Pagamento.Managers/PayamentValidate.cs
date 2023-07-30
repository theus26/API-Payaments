using API_Pagamento.DTO;
using API_Pagamento.Manager.Interfaces;

namespace API_Pagamento.Manager
{
    internal class PayamentValidate : IPayamentValidate
    {
        /// <summary>
        /// Esse é um metodo da classe acima que valida a entrada do valor da compra e retorna se a compra é APROVADA ou REJEITADA
        /// </summary>
        /// <param name="payament"></param>
        public ResponseDTO Validate(PayamentDTO payament)
        {
            try
            {
               if(payament.valor > 100)
                {
                    return new ResponseDTO()
                    {
                        Valor = payament.valor,
                        Estado = "APROVADO"
                    };
                }

                return new ResponseDTO()
                {
                    Valor = payament.valor,
                    Estado = "REJEITADO"
                };
            }

            catch
            {
                throw;
            }
        }
    }
}
