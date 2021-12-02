using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace ForTrek.API.Models
{
    public class Marca
    {
        [Key]
        public int MarcaId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Nome { get; set; }

        [Column(TypeName = "nvarchar(4)")]
        public string Ano_fundacao { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string Fundadores { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Sede { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string CEO { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string site { get; set; }
    }
}