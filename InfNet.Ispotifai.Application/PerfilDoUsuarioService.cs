using InfNet.Ispotifai.Application.Dto;
using InfNet.Ispotifai.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfNet.Ispotifai.Application
{

    public class PerfilDoUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMusicaRepository _musicaRepository;
        public PerfilDoUsuarioService(IUsuarioRepository usuarioRepository, IMusicaRepository musicaRepository)
        {
            _usuarioRepository = usuarioRepository;
            _musicaRepository = musicaRepository;
        }

        public UsuarioDto ObterPerfil(int id, string search)
        {
            var usuario = _usuarioRepository.ObterPorId(id);
            var musicas = _musicaRepository.ObterMusicas(search);

            var result = new UsuarioDto
            {
                IdUsuario = usuario.IdUsuario,
                Email = usuario.Email,
                Favoritas = musicas.Select(m => new MusicaFavoritaDto
                {
                    IdMusica = m.IdMusica,
                    Nome = m.Nome,
                    Artista = m.Artista,
                    Album = m.Album,
                    Favorita = usuario.Favoritas.Any(f => f.IdMusica == m.IdMusica)
                }).OrderBy(m => m.Nome).ToList()
            };
            return result;
        }
    }
}
