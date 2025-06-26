using InfNet.Ispotifai.Domain;
using InfNet.Ispotifai.Domain.Repository;
using System.Text.RegularExpressions;

namespace InfNet.Ispotifai.Application
{
    public class CadastrarUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IPlanoRepository _planoRepository;
        public CadastrarUsuarioService(IUsuarioRepository usuarioRepository, IPlanoRepository planoRepository)
        {
            _usuarioRepository = usuarioRepository;
            _planoRepository = planoRepository;
        }
        public int CadastrarUsuario(string email, string password, string confirmPassword, int plano)
        {
            bool emailValido = !string.IsNullOrEmpty(email) &&
                Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            bool senhasIguais = !string.IsNullOrEmpty(password) &&
                password == confirmPassword;
            bool planoValido = plano > 0;
            if (!emailValido || !senhasIguais || !planoValido)
            {
                throw new InvalidOperationException("Dados inválidos. Verifique o email, as senhas e o plano.");
            }

            Usuario usuario = _usuarioRepository.ObterPorEmail(email);
            usuario.Plano = _planoRepository.ObterPorId(plano);
            usuario.Senha = password;
            _usuarioRepository.Salvar(usuario);

            return usuario.IdUsuario;
        }

    }
}
