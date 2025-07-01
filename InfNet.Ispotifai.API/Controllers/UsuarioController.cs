using InfNet.Ispotifai.Application;
using InfNet.Ispotifai.Application.Dto;
using InfNet.Ispotifai.Domain.Repository;
using Microsoft.AspNetCore.Mvc;

namespace InfNet.Ispotifai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMusicaRepository _musicaRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository, IMusicaRepository musicaRepository)
        {
            _usuarioRepository = usuarioRepository;
            _musicaRepository = musicaRepository;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id, string search = "")
        {
            UsuarioDto usuario = new PerfilDoUsuarioService(_usuarioRepository, _musicaRepository).ObterPerfil(id, search);

            return Ok(usuario);
        }

        [HttpDelete("{id}/favorita/{idMusica}")]
        public IActionResult RemoverMusica(int id, int idMusica)
        {
            try
            {
                new RemoverFavoritaService(_usuarioRepository, _musicaRepository)
                     .RemoverFavorita(id, idMusica);
                return Ok(new { message = "Música removida com sucesso." });
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao remover música favorita: {ex.Message}");
            }
        }

        [HttpPost("{id}/favorita/{idMusica}")]
        public IActionResult AdicionarMusica(int id, int idMusica)
        {
            try
            {
                new AdicionarFavoritaService(_usuarioRepository, _musicaRepository)
                     .AdicionarFavorita(id, idMusica);
                return Ok(new { message = "Música adicionada com sucesso." });
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar música favorita: {ex.Message}");
            }
        }
    }
}
