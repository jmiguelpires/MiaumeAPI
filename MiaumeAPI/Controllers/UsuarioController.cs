
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiaumeAPI.Context;
using MiaumeAPI.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MiaumeAPI.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public UsuarioController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [Route("api/GetUsuario")]
        [HttpGet]
        public async Task<IActionResult> GetUsuario()
        {
            var Usuarios = await _appDbContext.Usuario.ToListAsync();

            return Ok(Usuarios);
        }

        [Route("api/GetUsuarioPorCPF")]
        [HttpGet]
        public async Task<IActionResult> GetUsuarioPorCPF(long cpfcnpj)
        {
            var UsuarioPorCPF = _appDbContext.Usuario
                .Where(u => u.CPFCNPJ == cpfcnpj)
                .FirstOrDefault();

            return Ok(UsuarioPorCPF);
        }

        [Route("api/GetUsuarioLogin")]
        [HttpGet]
        public async Task<IActionResult> GetUsuarioLogin(string email, string senha)
        {            
            var UsuarioLogin = _appDbContext.Usuario
                .Where(u => u.email == email && u.senha == senha)
                .FirstOrDefault();

            return Ok(UsuarioLogin);
        }

        [Route("api/CreateUsuario")]
        [HttpPost]
        public async Task<IActionResult> CreateUsuario(Usuario usuario)
        {
            _appDbContext.Usuario.Add(usuario);
            
            var Usuario = await _appDbContext.SaveChangesAsync();

            return Ok(Usuario);
        }

        [Route("api/UpdateUsuario")]
        [HttpPut]
        public async Task<IActionResult> UpdateUsuario(long cpfcnpj, Usuario usuario)
        {
            if (cpfcnpj != usuario.CPFCNPJ)
            {
                return BadRequest();
            }

            _appDbContext.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _appDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExiste(cpfcnpj))
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

        [Route("api/DeleteUsuario")]
        [HttpDelete]
        public async Task<IActionResult> DeleteUsuario(long cpfcnpj)
        {
            var usuario = await _appDbContext.Usuario.FindAsync(cpfcnpj);
            if (usuario == null)
            {
                return NotFound();
            }

            _appDbContext.Usuario.Remove(usuario);
            await _appDbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExiste(long cpfcnpj)
        {
            return _appDbContext.Usuario.Any(e => e.CPFCNPJ == cpfcnpj);
        }
    }
}