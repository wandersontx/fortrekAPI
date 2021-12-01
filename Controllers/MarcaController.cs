using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForTrek.API.Data;
using ForTrek.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForTrek.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MarcaController : ControllerBase
    {
        private readonly DataContext _context;

        public MarcaController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Marca>>> Get()
        {
            return await _context.marcas.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Marca>> GetById(int id)
        {
            var marca = await _context.marcas.FindAsync(id);

            if (marca == null)
            {
                return NotFound();
            }
            return marca;
        }

        [HttpPost]
        public async Task<ActionResult<Marca>> Post(Marca marca)
        {
            try
            {
                _context.marcas.Add(marca);
                if (await _context.SaveChangesAsync() > 0 ) {
                     return Created($"/api/Marca/{marca.MarcaId}", marca);
                }

            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError," Erro no salvar dados no banco de dados");
            }

            return BadRequest();
            
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Marca marca)
        {
            if (id != marca.MarcaId)
            {
                return BadRequest();
            }
            
            _context.Entry(marca).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if (!MarcaExists(id))
                {
                    return NotFound();
                }
                else 
                {
                    throw;
                }

               
            }

             return NoContent();
        }

        private bool MarcaExists(int id )
        {
            return  _context.marcas.FirstOrDefault(marca => marca.MarcaId == id) == null;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var marca = await _context.marcas.FindAsync(id);
            if (marca == null) {
                return NotFound();
            }

            _context.marcas.Remove(marca);
            await _context.SaveChangesAsync();
            return NoContent();

        }
    }
}