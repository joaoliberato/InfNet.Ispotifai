using InfNet.Ispotifai.API.Dto.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace InfNet.Ispotifai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("Register")]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            bool emailValido = !string.IsNullOrEmpty(request.Email) &&
                Regex.IsMatch(request.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            bool senhasIguais = !string.IsNullOrEmpty(request.Password) &&
                request.Password == request.ConfirmPassword;
            bool planoValido = request.Plano > 0;
            if (!emailValido || !senhasIguais || !planoValido)
            {
                return BadRequest("Dados inválidos. Verifique o email, as senhas e o plano.");
            }

            // Simulação de registro bem-sucedido
            int idUsuario = new Random().Next(1, 1000); // Simula um ID de usuário gerado
            return Ok(idUsuario);
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Simulação de registro bem-sucedido
            int idUsuario = new Random().Next(1, 1000); // Simula um ID de usuário gerado
            return Ok(idUsuario);
        }
    }
}
