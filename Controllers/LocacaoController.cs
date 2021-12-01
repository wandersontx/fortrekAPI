using System;
using System.Collections.Generic;
using System.Linq;
using ForTrek.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForTrek.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocacaoController : ControllerBase
    {
        public IEnumerable<Locacao> _locacao = new Locacao[]{
               new Locacao {
                LocacaoId    = 1,
                data_inicial = DateTime.Now.ToString(),
                data_final   = DateTime.Now.AddMonths(3).ToString(),
                valor_diaria = (float)86.30,
                cliente_id   = 1,
                carro_id     = 1
               },
                new Locacao {
                LocacaoId    = 2,
                data_inicial = DateTime.Now.AddMonths(4).ToString(),
                data_final   = DateTime.Now.AddYears(1).ToString(),
                valor_diaria = (float)90.00,
                cliente_id   = 2,
                carro_id     = 2
               },
               new Locacao {
                LocacaoId    = 3,
                data_inicial = DateTime.Now.AddMonths(5).ToString(),
                data_final   = DateTime.Now.AddYears(1).ToString(),
                valor_diaria = (float)120.00,
                cliente_id   = 3,
                carro_id     = 3
               }
            };

        public LocacaoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Locacao> Get()
        {
            return _locacao;
        }

        [HttpPost]
        public string Post()
        {
            return "method post";
        }

        
        [HttpPut("{id}")]
        public string Put(int id )
        {
            return $"method put {id}";
        }

        [HttpGet("{id}")]
        public IEnumerable<Locacao> GetById(int id)
        {
            return _locacao.Where(locacao => locacao.LocacaoId == id);
        }

        
        [HttpDelete("{id}")]
        public string delete(int id)
        {
            return $"method delete {id}";
        }
    }
}
