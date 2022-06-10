
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiaumeAPI.Context;
using MiaumeAPI.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MiaumeAPI.Controllers
{
    [ApiController]
    public class UsuarioPetController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public UsuarioPetController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [Route("api/GetPetUsuario")]
        [HttpGet]
        public async Task<IActionResult> GetPetUsuario()
        {

            var PetsAdocao = await _appDbContext.UsuarioPet
                .OrderByDescending(u => u.dtCadastro)
                .ToListAsync();

            return Ok(PetsAdocao);
        }

        [Route("api/CreatePetUsuario")]
        [HttpPost]
        public async Task<IActionResult> CreatePetUsuario(UsuarioPet usuarioPet)
        {
            _appDbContext.UsuarioPet.Add(usuarioPet);
            await _appDbContext.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                data = usuarioPet
            });

        }

        [Route("api/UpdatePetUsuario")]
        [HttpPut]
        public async Task<IActionResult> UpdatePetUsuario(long cpfcnpj, long idPet, UsuarioPet usuarioPet)
        {
            if (cpfcnpj != usuarioPet.CPFCNPJ && idPet != usuarioPet.idPet)
            {
                return BadRequest();
            }

            _appDbContext.Entry(usuarioPet).State = EntityState.Modified;

            try
            {
                await _appDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return NoContent();

        }

        [Route("api/DeletePetUsuario")]
        [HttpDelete]
        public async Task<IActionResult> DeletePetUsuario(long idPet)
        {
            var petUsuario = await _appDbContext.UsuarioPet.FindAsync(idPet);
            if (petUsuario == null)
            {
                return NotFound();
            }

            _appDbContext.UsuarioPet.Remove(petUsuario);
            await _appDbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}