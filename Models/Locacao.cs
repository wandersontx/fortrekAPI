namespace ForTrek.API.Models
{
    public class Locacao
    {
       public int LocacaoId { get; set; }
        public string data_inicial { get; set; }
        public string data_final { get; set; }
        public float valor_diaria { get; set; }
        public int cliente_id { get; set; }
        public int carro_id { get; set; }
    }
}