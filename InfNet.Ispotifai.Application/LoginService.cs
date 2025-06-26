using InfNet.Ispotifai.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.Ispotifai.Application
{
    public class LoginService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public LoginService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public int Login(string email, string password)
        {
            // Simulação de login bem-sucedido
            // Aqui você deve implementar a lógica real de autenticação
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Email e senha são obrigatórios.");
            }
            // Verifica se o usuário existe no repositório
            var usuario = _usuarioRepository.ObterPorEmail(email);
            if (usuario == null || usuario.Senha != password)
            {
                throw new UnauthorizedAccessException("Email ou senha inválidos.");
            }
            return usuario.IdUsuario; // Retorna o ID do usuário autenticado
        }
    }
}
