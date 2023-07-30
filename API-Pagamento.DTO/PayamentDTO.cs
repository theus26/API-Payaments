namespace API_Pagamento.DTO
{
        public class PayamentDTO
        {
          public float valor { get; set; }
          public Cartao cartao { get; set; }
        }

    public class Cartao
    {
        public string titular { get; set; }
        public string numero { get; set; }
        public string data_expiracao { get; set; }
        public string bandeira { get; set; }
        public string cvv { get; set; }
    }

}
