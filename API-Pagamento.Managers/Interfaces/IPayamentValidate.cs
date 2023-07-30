


using API_Pagamento.DTO;

namespace API_Pagamento.Manager.Interfaces
{
    public interface IPayamentValidate
    {
        ResponseDTO Validate(PayamentDTO payament);
    }
}
