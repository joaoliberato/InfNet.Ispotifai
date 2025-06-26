using InfNet.Ispotifai.API.Dto.Request;
using InfNet.Ispotifai.Application;
using InfNet.Ispotifai.Domain.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace InfNet.Ispotifai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IPlanoRepository _planoRepository;
        public AccountController(IUsuarioRepository usuarioRepository, IPlanoRepository planoRepository)
        {
            _usuarioRepository = usuarioRepository;
            _planoRepository = planoRepository;
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            CadastrarUsuarioService cadastrarUsuarioService = new CadastrarUsuarioService(_usuarioRepository, _planoRepository);
            var idUsuario = 0;
            try
            {
                idUsuario = cadastrarUsuarioService.CadastrarUsuario(request.Email, request.Password, request.ConfirmPassword, request.Plano);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao cadastrar usuário: {ex.Message}");
            }

            return Ok(idUsuario);
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            return Ok(new LoginService(_usuarioRepository).Login(request.Email, request.Password));
        }
    }
}
