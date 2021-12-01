using Microsoft.AspNetCore.Mvc;

namespace ForTrek.API.Models
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Nome { get; set; }
        public string Ano_fundacao { get; set; }
        public string Fundador { get; set; }
        public string Sede { get; set; }
        public string CEO { get; set; }
        public string site { get; set; }
    }
}