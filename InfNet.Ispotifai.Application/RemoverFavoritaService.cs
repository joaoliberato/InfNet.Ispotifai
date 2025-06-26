using InfNet.Ispotifai.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.Ispotifai.Application
{
    public class RemoverFavoritaService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMusicaRepository _musicaRepository;
        public RemoverFavoritaService(IUsuarioRepository usuarioRepository, IMusicaRepository musicaRepository)
        {
            _usuarioRepository = usuarioRepository;
            _musicaRepository = musicaRepository;
        }
        public void RemoverFavorita(int idUsuario, int idMusica)
        {
            var usuario = _usuarioRepository.ObterPorId(idUsuario);
            if (usuario == null)
            {
                throw new ArgumentException("Usuário não encontrado.");
            }
            var musica = usuario.Favoritas.FirstOrDefault(f => f.IdMusica == idMusica);
            usuario.RemoveFavorita(idMusica);
            _usuarioRepository.Salvar(usuario);
        }
    }
}
