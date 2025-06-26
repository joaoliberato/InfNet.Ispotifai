using InfNet.Ispotifai.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.Ispotifai.Application
{
    public class AdicionarFavoritaService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMusicaRepository _musicaRepository;
        public AdicionarFavoritaService(
            IUsuarioRepository usuarioRepository,
            IMusicaRepository musicaRepository)
        {
            _usuarioRepository = usuarioRepository;
            _musicaRepository = musicaRepository;
        }
        public void AdicionarFavorita(int idUsuario, int idMusica)
        {
            var usuario = _usuarioRepository.ObterPorId(idUsuario);
            if (usuario == null)
                throw new Exception("Usuário não encontrado");
            var musica = _musicaRepository.ObterPorId(idMusica);
            if (musica == null)
                throw new Exception("Música não existe");
            usuario.AddFavorita(musica);
            _usuarioRepository.Salvar(usuario);
        }
    }
}
