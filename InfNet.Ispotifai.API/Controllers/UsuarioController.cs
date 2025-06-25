using InfNet.Ispotifai.API.Dto.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InfNet.Ispotifai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // Simulate fetching user data
            return Ok(new UsuarioResponse
            {
                Email = "teste@teste.com",
                IdUsuario = id,
                Favoritas = [
                    new () { IdMusica = 1, Nome = "Música 1", Artista = "Artista 1", Favorita = false },
                    new () { IdMusica = 2, Nome = "Música 2", Artista = "Artista 2", Favorita = true },
                ]
            });
        }
    }
}
